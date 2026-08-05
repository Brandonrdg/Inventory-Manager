using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaDeInventarioWinForms
{
    public partial class FormPrincipal : Form
    {
        public Inventario inventario = new Inventario();

        private void CargarProductos()
        {
            dgvProductos.DataSource = inventario.ObtenerProductos();

            lblProductos.Text = $"📦Productos: {inventario.ObtenerCantidadProductos()}";
            lblStock.Text = $"📊Stock Total: {inventario.ObtenerStockTotal()}";
            lblValor.Text = $"💰Valor Total: ${inventario.ObtenerValorTotalInventario():N2}";
        }
        public FormPrincipal()
        {
            InitializeComponent();

            CargarProductos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarProductos formulario = new FormAgregarProductos();
            formulario.ShowDialog();
            CargarProductos();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value);

            Producto producto = inventario.BuscarProductoPorId(id);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            FormActualizarProductos formulario = new FormActualizarProductos(producto);
            formulario.ShowDialog();

            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value);
            Producto producto = inventario.BuscarProductoPorId(id);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            FormEliminarProducto formulario = new FormEliminarProducto(producto);
            formulario.ShowDialog();

            CargarProductos();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            dgvProductos.DataSource = string.IsNullOrWhiteSpace(filtro)
                ? inventario.ObtenerProductos()
                : inventario.BuscarProductos(filtro);
        }
    }
}
