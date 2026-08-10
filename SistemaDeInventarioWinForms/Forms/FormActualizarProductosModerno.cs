using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeInventarioWinForms.Forms
{
    public partial class FormActualizarProductosModerno : Form
    {
        private readonly Inventario inventario = new Inventario();

        private readonly Producto producto;
        public FormActualizarProductosModerno(Producto producto)
        {
            InitializeComponent();

            this.producto = producto;

            txtNombre.Text = producto.Nombre;
            txtCantidad.Text = producto.Cantidad.ToString();
            txtPrecio.Text = producto.Precio.ToString();

        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();
            string cantidadText = txtCantidad.Text.Trim();
            string precioText = txtPrecio.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(cantidadText) || string.IsNullOrEmpty(precioText))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(cantidadText, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero positivo igual o mayor a 0.");
                return;
            }

            if (!decimal.TryParse(precioText, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor a 0.");
                return;
            }

            inventario.ActualizarProducto(nombre, cantidad, precio, producto.Id);
            MessageBox.Show("Producto actualizado correctamente.");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
