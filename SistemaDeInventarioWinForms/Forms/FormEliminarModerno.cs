using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            ConfigurarTemaDataGridView();
        }
        private void CargarProducto()
        {
            dgvProductoEliminar.DataSource = new List<Producto>
            {
                producto
            };
            dgvProductoEliminar.CellFormatting += DgvProductos_CellFormatting;
        }
        private void ConfigurarTemaDataGridView()
        {

            dgvProductoEliminar.ThemeStyle.BackColor = Color.FromArgb(24, 24, 27);

            // Encabezado
            dgvProductoEliminar.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(39, 39, 42);
            dgvProductoEliminar.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvProductoEliminar.ThemeStyle.HeaderStyle.Font =
                new Font("Segoe UI", 6, FontStyle.Bold);
            dgvProductoEliminar.ThemeStyle.HeaderStyle.Height = 30;

            // Filas
            dgvProductoEliminar.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(24, 24, 27);
            dgvProductoEliminar.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dgvProductoEliminar.ThemeStyle.RowsStyle.SelectionBackColor =
                Color.FromArgb(30, 58, 95);
            dgvProductoEliminar.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvProductoEliminar.ThemeStyle.RowsStyle.Font =
                new Font("Segoe UI", 10);
            dgvProductoEliminar.ThemeStyle.RowsStyle.Height = 42;

            // Filas alternas
            dgvProductoEliminar.ThemeStyle.AlternatingRowsStyle.BackColor =
                Color.FromArgb(32, 32, 36);

            dgvProductoEliminar.GridColor = Color.FromArgb(63, 63, 70);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estas seguro que deseas eliminar este producto?",
               "Confirmacion", MessageBoxButtons.OKCancel);
            if (respuesta == DialogResult.OK)
            {
                inventario.EliminarProducto(producto);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DgvProductos_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductoEliminar.Columns[e.ColumnIndex].Name == "Precio" && e.Value is decimal precio)
            {
                e.Value = $"₡{precio:N0}";
                e.FormattingApplied = true;
            }
        }
    }
}
