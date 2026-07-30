using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Data.Sqlite;
public class Inventario
{
    private BaseDatos db = new BaseDatos();


    //Método para agregar un producto a la base de datos
    public void AgregarProducto(string nombre, int cantidad, float precio)
    {
        using (var conexion = db.ObtenerConexion())
        {
            conexion.Open();


            string sql = @"INSERT INTO Productos (Nombre, Cantidad, Precio) VALUES (@Nombre, @Cantidad, @Precio)";

            SqliteCommand comando = new SqliteCommand(sql, conexion);

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@Precio", precio);

            comando.ExecuteNonQuery();
        }
    }
    //Metodo para actualizar producto
    public void ActualizarProducto(string nombre, int cantidad, float precio, int id)
    {

        using (var conexion = db.ObtenerConexion())
        {
            conexion.Open();

            var command = new SqliteCommand("UPDATE Productos SET Nombre = " +
                "@Nombre, Cantidad = @Cantidad, Precio = @Precio WHERE Id = @Id", conexion);

            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Cantidad", cantidad);
            command.Parameters.AddWithValue("@Precio", precio);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

    }
    //Metodo para eliminar producto
    public void EliminarProducto(Producto producto)
    {
        using (var conexion = db.ObtenerConexion())
        {
            conexion.Open();
            var command = new SqliteCommand("DELETE FROM Productos WHERE Id = @Id", conexion);
            command.Parameters.AddWithValue("@Id", producto.Id);
            command.ExecuteNonQuery();
        }



    }
    public List<Producto> LeerProductos(string nombreFiltro = null)
    {
        var productos = new List<Producto>();

        using (var conexion = db.ObtenerConexion())
        {
            conexion.Open();

            string sql = "SELECT * FROM Productos";


            if (!string.IsNullOrWhiteSpace(nombreFiltro))
                sql += " WHERE Nombre LIKE @NombreFiltro";


            using (var cmd = new SqliteCommand(sql, conexion))
            {
                if (!string.IsNullOrWhiteSpace(nombreFiltro))
                    cmd.Parameters.AddWithValue("@NombreFiltro", $"%{nombreFiltro}%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(LeerProducto(reader));
                    }
                }
            }
        } return productos;
    }

    private Producto LeerProducto(SqliteDataReader reader)
    {
        Producto producto = new Producto();

        producto.Id = Convert.ToInt32(reader["Id"]);
        producto.Nombre = Convert.ToString(reader["Nombre"]);
        producto.Cantidad = Convert.ToInt32(reader["Cantidad"]);
        producto.Precio = Convert.ToDecimal(reader["Precio"]);
        return producto;
    }

    public List<Producto> ObtenerProductos() => LeerProductos();

    public List<Producto> BuscarProductos(string nombre) => LeerProductos(nombre);
    public Producto BuscarProductoPorId(int id)
    {
        using (var conexion = db.ObtenerConexion())
        {
            conexion.Open();

            var command = new SqliteCommand(
                "SELECT * FROM Productos WHERE Id = @Id",
                conexion);

            command.Parameters.AddWithValue("@Id", id);

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return LeerProducto(reader);
                }
            }
        }

        return null;
    }
    public int ObtenerCantidadProductos() 
    {
        return ObtenerProductos().Count;
    }
    public int ObtenerStockTotal()
    {
       return ObtenerProductos().Sum(p => p.Cantidad);
    }
    public decimal ObtenerValorTotalInventario()
    {
        return ObtenerProductos().Sum(p => p.Cantidad * p.Precio);
    }
}