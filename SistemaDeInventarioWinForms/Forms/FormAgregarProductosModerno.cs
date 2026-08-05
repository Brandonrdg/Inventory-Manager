using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaDeInventarioWinForms.Forms
{
    public partial class FormAgregarProductosModerno : Form
    {
        private readonly Inventario inventario = new Inventario();

        public FormAgregarProductosModerno()
        {
            InitializeComponent();
        }

        private void FormAgregarProductos_Load(object sender, EventArgs e) { }

        private void txtNombre_TextChanged(object sender, EventArgs e) { }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string cantidadText = txtCantidad.Text.Trim();
            string precioText = txtPrecio.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido.");
                return;
            }

            if (!int.TryParse(cantidadText, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida mayor a 0.");
                return;
            }

            if (!float.TryParse(precioText, out float precio) || precio < 0f)
            {
                MessageBox.Show("Por favor, ingrese un precio válido mayor o igual a 0.");
                return;
            }

            inventario.AgregarProducto(nombre, cantidad, precio);

            MessageBox.Show("Producto agregado correctamente.");

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
