using System;
using System.Windows.Forms;

namespace SistemaDeInventarioWinForms
{
    public partial class FormAgregarProductos : Form
    {
        private readonly Inventario inventario = new Inventario();

        public FormAgregarProductos()
        {
            InitializeComponent();
        }

        private void FormAgregarProductos_Load(object sender, EventArgs e) { }

        private void txtNombre_TextChanged(object sender, EventArgs e) { }

        private void btnGuardar(object sender, EventArgs e)
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

            if (!decimal.TryParse(precioText, out decimal precio) || precio < 0m)
            {
                MessageBox.Show("Por favor, ingrese un precio válido mayor o igual a 0.");
                return;
            }

            inventario.AgregarProducto(nombre, cantidad, precio);

            MessageBox.Show("Producto agregado correctamente.");

            Close();
        }

        private void button2_Click(object sender, EventArgs e) => Close();
    }
}
