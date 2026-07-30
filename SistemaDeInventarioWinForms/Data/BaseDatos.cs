using Microsoft.Data.Sqlite;

public class BaseDatos
{
    private string conexion = "Data Source=Inventario.db";

    public SqliteConnection ObtenerConexion()
    {
        return new SqliteConnection(conexion);
    }
}