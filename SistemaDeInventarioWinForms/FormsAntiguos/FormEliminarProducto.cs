using System;
using System.Windows.Forms;

namespace SistemaDeInventarioWinForms
{
    public partial class FormEliminarProducto : Form
    {
        private readonly Inventario inventario = new Inventario();
        private readonly Producto producto;

        public FormEliminarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto ?? throw new ArgumentNullException(nameof(producto));

            txtNombre.Text = producto.Nombre;
            txtCantidad.Text = producto.Cantidad.ToString();
            txtPrecio.Text = producto.Precio.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estas seguro que deseas eliminar este producto?",
                "Confirmacion",MessageBoxButtons.OKCancel);
            inventario.EliminarProducto(producto);
            Close();
        }
    }
}
