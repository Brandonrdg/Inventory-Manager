namespace SistemaDeInventarioWinForms
{
    partial class FormPrincipal
    {
        private const string V = "Inventory Manager";

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PaneSuperior = new Guna.UI2.WinForms.Guna2Panel();
            Tittle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PanelPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            Text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            PanelInferior = new Guna.UI2.WinForms.Guna2Panel();
            btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            PanelDatos = new Guna.UI2.WinForms.Guna2Panel();
            lblValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblStock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblProductos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PaneSuperior.SuspendLayout();
            PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            PanelInferior.SuspendLayout();
            PanelDatos.SuspendLayout();
            SuspendLayout();
            // 
            // PaneSuperior
            // 
            PaneSuperior.BackColor = Color.FromArgb(39, 39, 42);
            PaneSuperior.Controls.Add(Tittle);
            PaneSuperior.CustomizableEdges = customizableEdges1;
            PaneSuperior.Location = new Point(12, 12);
            PaneSuperior.Name = "PaneSuperior";
            PaneSuperior.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PaneSuperior.Size = new Size(660, 77);
            PaneSuperior.TabIndex = 0;
            // 
            // Tittle
            // 
            Tittle.BackColor = Color.Transparent;
            Tittle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Tittle.ForeColor = Color.FromArgb(250, 250, 250);
            Tittle.Location = new Point(230, 22);
            Tittle.Margin = new Padding(0);
            Tittle.Name = "Tittle";
            Tittle.Size = new Size(191, 32);
            Tittle.TabIndex = 0;
            Tittle.Text = "Inventory Manager";
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = Color.FromArgb(39, 39, 42);
            PanelPrincipal.Controls.Add(txtBuscar);
            PanelPrincipal.Controls.Add(Text);
            PanelPrincipal.Controls.Add(dgvProductos);
            PanelPrincipal.CustomizableEdges = customizableEdges5;
            PanelPrincipal.Location = new Point(12, 95);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PanelPrincipal.Size = new Size(660, 206);
            PanelPrincipal.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderColor = Color.FromArgb(63, 63, 70);
            txtBuscar.BorderRadius = 8;
            txtBuscar.CustomizableEdges = customizableEdges3;
            txtBuscar.DefaultText = "";
            txtBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.FillColor = Color.FromArgb(39, 39, 42);
            txtBuscar.FocusedState.BorderColor = Color.FromArgb(37, 99, 235);
            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.ForeColor = Color.White;
            txtBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscar.Location = new Point(102, 20);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderForeColor = Color.FromArgb(161, 161, 170);
            txtBuscar.PlaceholderText = "Buscar productos.....";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtBuscar.Size = new Size(387, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // Text
            // 
            Text.BackColor = Color.Transparent;
            Text.Font = new Font("Segoe UI", 12F);
            Text.ForeColor = Color.FromArgb(161, 161, 170);
            Text.Location = new Point(30, 26);
            Text.Name = "Text";
            Text.Size = new Size(49, 23);
            Text.TabIndex = 1;
            Text.Text = "Buscar";
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(32, 32, 36);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.BackgroundColor = Color.FromArgb(24, 24, 27);
            dgvProductos.BorderStyle = BorderStyle.Fixed3D;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(39, 39, 42);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.GridColor = Color.FromArgb(63, 63, 70);
            dgvProductos.Location = new Point(30, 54);
            dgvProductos.Margin = new Padding(30);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 41;
            dgvProductos.Size = new Size(587, 143);
            dgvProductos.TabIndex = 0;
            dgvProductos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(32, 32, 36);
            dgvProductos.ThemeStyle.BackColor = Color.FromArgb(24, 24, 27);
            dgvProductos.ThemeStyle.GridColor = Color.FromArgb(63, 63, 70);
            dgvProductos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(39, 39, 42);
            dgvProductos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F);
            dgvProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.ThemeStyle.HeaderStyle.Height = 32;
            dgvProductos.ThemeStyle.ReadOnly = true;
            dgvProductos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single;
            dgvProductos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvProductos.ThemeStyle.RowsStyle.Height = 41;
            // 
            // PanelInferior
            // 
            PanelInferior.BackColor = Color.FromArgb(24, 24, 27);
            PanelInferior.Controls.Add(btnEliminar);
            PanelInferior.Controls.Add(btnEditar);
            PanelInferior.Controls.Add(btnAgregar);
            PanelInferior.CustomizableEdges = customizableEdges13;
            PanelInferior.Location = new Point(12, 307);
            PanelInferior.Name = "PanelInferior";
            PanelInferior.ShadowDecoration.CustomizableEdges = customizableEdges14;
            PanelInferior.Size = new Size(660, 60);
            PanelInferior.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BorderRadius = 8;
            btnEliminar.CustomizableEdges = customizableEdges7;
            btnEliminar.DisabledState.BorderColor = Color.DarkGray;
            btnEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEliminar.FillColor = Color.FromArgb(220, 38, 38);
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.HoverState.FillColor = Color.FromArgb(185, 28, 28);
            btnEliminar.Location = new Point(474, 15);
            btnEliminar.Margin = new Padding(30);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnEliminar.Size = new Size(174, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BorderRadius = 8;
            btnEditar.CustomizableEdges = customizableEdges9;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.White;
            btnEditar.FillColor = Color.FromArgb(37, 99, 235);
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ForeColor = Color.White;
            btnEditar.HoverState.FillColor = Color.FromArgb(29, 78, 216);
            btnEditar.Location = new Point(240, 15);
            btnEditar.Margin = new Padding(30);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnEditar.Size = new Size(174, 30);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BorderRadius = 8;
            btnAgregar.CustomizableEdges = customizableEdges11;
            btnAgregar.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar.DisabledState.ForeColor = Color.White;
            btnAgregar.FillColor = Color.FromArgb(37, 99, 235);
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.HoverState.FillColor = Color.FromArgb(29, 78, 216);
            btnAgregar.Location = new Point(11, 15);
            btnAgregar.Margin = new Padding(35, 35, 25, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAgregar.Size = new Size(174, 30);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // PanelDatos
            // 
            PanelDatos.BackColor = Color.FromArgb(24, 24, 27);
            PanelDatos.Controls.Add(lblValor);
            PanelDatos.Controls.Add(lblStock);
            PanelDatos.Controls.Add(lblProductos);
            PanelDatos.CustomizableEdges = customizableEdges15;
            PanelDatos.Location = new Point(12, 386);
            PanelDatos.Name = "PanelDatos";
            PanelDatos.ShadowDecoration.CustomizableEdges = customizableEdges16;
            PanelDatos.Size = new Size(660, 22);
            PanelDatos.TabIndex = 3;
            // 
            // lblValor
            // 
            lblValor.BackColor = Color.Transparent;
            lblValor.Font = new Font("Segoe UI", 9F);
            lblValor.ForeColor = Color.FromArgb(161, 161, 170);
            lblValor.Location = new Point(451, 2);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(38, 17);
            lblValor.TabIndex = 5;
            lblValor.Text = "Buscar";
            // 
            // lblStock
            // 
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Segoe UI", 9F);
            lblStock.ForeColor = Color.FromArgb(161, 161, 170);
            lblStock.Location = new Point(230, 3);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(38, 17);
            lblStock.TabIndex = 4;
            lblStock.Text = "Buscar";
            // 
            // lblProductos
            // 
            lblProductos.BackColor = Color.Transparent;
            lblProductos.Font = new Font("Segoe UI", 9F);
            lblProductos.ForeColor = Color.FromArgb(161, 161, 170);
            lblProductos.Location = new Point(11, 3);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(38, 17);
            lblProductos.TabIndex = 3;
            lblProductos.Text = "Buscar";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 63, 70);
            ClientSize = new Size(684, 411);
            Controls.Add(PanelDatos);
            Controls.Add(PanelInferior);
            Controls.Add(PanelPrincipal);
            Controls.Add(PaneSuperior);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            PaneSuperior.ResumeLayout(false);
            PaneSuperior.PerformLayout();
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            PanelInferior.ResumeLayout(false);
            PanelDatos.ResumeLayout(false);
            PanelDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PaneSuperior;
        private Guna.UI2.WinForms.Guna2Panel PanelPrincipal;
        private Guna.UI2.WinForms.Guna2Panel PanelInferior;
        private Guna.UI2.WinForms.Guna2Panel PanelDatos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductos;
        private Guna.UI2.WinForms.Guna2HtmlLabel Tittle;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2HtmlLabel Text;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStock;
    }
}