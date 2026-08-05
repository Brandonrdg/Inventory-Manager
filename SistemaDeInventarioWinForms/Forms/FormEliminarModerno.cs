using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaDeInventarioWinForms.Forms
{
    public partial class FormEliminarModerno : Form
    {
        private readonly Producto producto;
        private readonly Inventario inventario = new Inventario();
        public FormEliminarModerno(Producto producto)
        {
            InitializeComponent();

            this.producto = producto;

            CargarProducto();
        }
        private void CargarProducto()
        {
            dgvProductoEliminar.DataSource = new List<Producto>
            {
                producto
            };
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estas seguro que deseas eliminar este producto?",
               "Confirmacion", MessageBoxButtons.OKCancel);
            inventario.EliminarProducto(producto);
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
