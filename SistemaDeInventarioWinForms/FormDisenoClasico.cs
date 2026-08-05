using System;
using System.Windows.Forms;

namespace SistemaDeInventarioWinForms
{
    public partial class FormDisenoClasico : Form
    {
        public Inventario inventario = new Inventario();

        private void CargarProductos()
        {
            dgvProductos.DataSource = inventario.ObtenerProductos();

            lblProductos.Text = $"📦Productos: {inventario.ObtenerCantidadProductos()}";
            lblCantidad.Text = $"📊Stock Total: {inventario.ObtenerStockTotal()}";
            lblValorInventario.Text = $"💰Valor Total: ${inventario.ObtenerValorTotalInventario():N2}";
        }
        public FormDisenoClasico()
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
        private void btnActualizar_Click(object sender, EventArgs e)
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
    }
}
