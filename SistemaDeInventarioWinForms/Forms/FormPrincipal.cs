using SistemaDeInventarioWinForms.Forms;
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
            var productos = inventario.ObtenerProductos();

            dgvProductos.DataSource = productos;

            dgvProductos.Columns["Id"].Visible = false;

            dgvProductos.CellFormatting += DgvProductos_CellFormatting;

            dgvProductos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvProductos.Columns["Nombre"].FillWeight = 55;

            dgvProductos.Columns["Cantidad"].FillWeight = 20;

            dgvProductos.Columns["Precio"].FillWeight = 25;

            dgvProductos.Columns["Nombre"].HeaderText = "Producto";
            dgvProductos.Columns["Cantidad"].HeaderText = "Stock";
            dgvProductos.Columns["Precio"].HeaderText = "Precio";


            lblProductos.Text = $"Productos:";
            lblTotal.Text = productos.Count.ToString();
            lblStock.Text = $"Stock Total:";
            lblStockTotal.Text = productos.Sum(p => p.Cantidad).ToString();
            lblValor.Text = $"Valor Total:";
            decimal ValorTotal = productos.Sum(p => p.Cantidad * p.Precio);
            lblValorTotal.Text = $"₡{ValorTotal:N0}";

        }

        private void DgvProductos_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Precio" && e.Value != null)
            {
                // Si el origen de datos ya proporciona un decimal, formatear directamente.
                if (e.Value is decimal precioDecimal)
                {
                    e.Value = $"₡{precioDecimal:N0}";
                    e.FormattingApplied = true;
                    return;
                }

                // Intentar convertir valores no nulos de forma segura.
                // Primero intentar Convert (maneja tipos numéricos), y si falla, intentar parsear cadenas estilo moneda.
                try
                {
                    decimal precio = Convert.ToDecimal(e.Value);
                    e.Value = $"₡{precio:N0}";
                    e.FormattingApplied = true;
                    return;
                }
                catch (FormatException)
                {
                    // Podría ser una cadena ya formateada con símbolo de moneda (ej. "₡44 000").
                    if (decimal.TryParse(
                        e.Value.ToString(),
                        System.Globalization.NumberStyles.Currency,
                        System.Globalization.CultureInfo.CurrentCulture,
                        out decimal parsed))
                    {
                        e.Value = $"₡{parsed:N0}";
                        e.FormattingApplied = true;
                        return;
                    }
                }
                catch
                {
                    // En cualquier otro fallo, no modificar e.Value para evitar excepción.
                }
            }
        }

        public FormPrincipal()
        {
            InitializeComponent();

            ConfigurarTemaDataGrid();

            CargarProductos();

        }
        private void ConfigurarTemaDataGrid()
        {

            dgvProductos.ThemeStyle.BackColor = Color.FromArgb(24, 24, 27);

            // Encabezado
            dgvProductos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(39, 39, 42);
            dgvProductos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvProductos.ThemeStyle.HeaderStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProductos.ThemeStyle.HeaderStyle.Height = 45;

            // Filas
            dgvProductos.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(24, 24, 27);
            dgvProductos.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dgvProductos.ThemeStyle.RowsStyle.SelectionBackColor =
                Color.FromArgb(30, 58, 95);
            dgvProductos.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvProductos.ThemeStyle.RowsStyle.Font =
                new Font("Segoe UI", 10);
            dgvProductos.ThemeStyle.RowsStyle.Height = 42;

            // Filas alternas
            dgvProductos.ThemeStyle.AlternatingRowsStyle.BackColor =
                Color.FromArgb(32, 32, 36);

            dgvProductos.GridColor = Color.FromArgb(63, 63, 70);

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
            FormAgregarProductosModerno formulario = new FormAgregarProductosModerno();
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

            FormActualizarProductosModerno formulario = new FormActualizarProductosModerno(producto);
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

            FormEliminarModerno formulario = new FormEliminarModerno(producto);
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

        private void lblProductos_Click(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void TxtVersion_Click(object sender, EventArgs e)
        {

        }

        private void lblStockTotal_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            dgvProductos.ClearSelection();
            dgvProductos.CurrentCell = null;
        }
    }
}
