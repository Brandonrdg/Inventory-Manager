using System;
using System.Windows.Forms;

namespace SistemaDeInventarioWinForms
{
    public partial class FormActualizarProductos : Form
    {
        private Inventario inventario = new Inventario();

        private Producto producto;
        public FormActualizarProductos(Producto producto)
        {
            InitializeComponent();

            this.producto = producto;

            txtNombre.Text = producto.Nombre;
            txtCantidad.Text = producto.Cantidad.ToString();
            txtPrecio.Text = producto.Precio.ToString();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string cantidadText = txtCantidad.Text.Trim();
            string precioText = txtPrecio.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(cantidadText) || string.IsNullOrEmpty(precioText))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(cantidadText, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.");
                return;
            }

            if (!float.TryParse(precioText, out float precio))
            {
                MessageBox.Show("El precio debe ser un número decimal.");
                return;
            }

            inventario.ActualizarProducto(nombre, cantidad, precio, producto.Id);
            MessageBox.Show("Producto actualizado correctamente.");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
