namespace SistemaDeInventarioWinForms
{
    partial class FormDisenoClasico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SistemaDeInventario = new Label();
            dgvProductos = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            panelSuperior = new Panel();
            panelContenido = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            lblValorInventario = new Label();
            lblCantidad = new Label();
            lblProductos = new Label();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panelSuperior.SuspendLayout();
            panelContenido.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SistemaDeInventario
            // 
            SistemaDeInventario.AutoSize = true;
            SistemaDeInventario.BackColor = Color.Black;
            SistemaDeInventario.BorderStyle = BorderStyle.FixedSingle;
            SistemaDeInventario.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            SistemaDeInventario.ForeColor = SystemColors.ControlLightLight;
            SistemaDeInventario.ImageAlign = ContentAlignment.TopCenter;
            SistemaDeInventario.Location = new Point(6, 9);
            SistemaDeInventario.Name = "SistemaDeInventario";
            SistemaDeInventario.Size = new Size(260, 33);
            SistemaDeInventario.TabIndex = 0;
            SistemaDeInventario.Text = "📦 Inventory Manager";
            SistemaDeInventario.TextAlign = ContentAlignment.TopCenter;
            SistemaDeInventario.Click += label1_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 99);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(454, 102);
            dgvProductos.TabIndex = 4;
            dgvProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(37, 99, 235);
            button2.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 17);
            button2.Margin = new Padding(40, 3, 40, 3);
            button2.Name = "button2";
            button2.Size = new Size(98, 30);
            button2.TabIndex = 5;
            button2.Text = "➕Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnAgregar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(37, 99, 235);
            button3.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(190, 17);
            button3.Margin = new Padding(40, 3, 40, 3);
            button3.Name = "button3";
            button3.Size = new Size(98, 30);
            button3.TabIndex = 6;
            button3.Text = "✏️Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnActualizar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(220, 38, 38);
            button4.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(368, 17);
            button4.Margin = new Padding(40, 3, 40, 3);
            button4.Name = "button4";
            button4.Size = new Size(98, 30);
            button4.TabIndex = 7;
            button4.Text = "🗑️Eliminar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(189, 27);
            label1.TabIndex = 8;
            label1.Text = "🔎 Buscar producto";
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(39, 39, 42);
            panelSuperior.Controls.Add(SistemaDeInventario);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(621, 70);
            panelSuperior.TabIndex = 10;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(24, 24, 27);
            panelContenido.Controls.Add(guna2TextBox2);
            panelContenido.Controls.Add(panel1);
            panelContenido.Controls.Add(label1);
            panelContenido.Controls.Add(dgvProductos);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 70);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(621, 316);
            panelContenido.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 42);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 102);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblValorInventario);
            panel2.Controls.Add(lblCantidad);
            panel2.Controls.Add(lblProductos);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 31);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(39, 39, 42);
            label2.Font = new Font("Segoe UI", 5F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(603, 21);
            label2.Name = "label2";
            label2.Size = new Size(18, 10);
            label2.TabIndex = 3;
            label2.Text = "v1.0";
            // 
            // lblValorInventario
            // 
            lblValorInventario.AutoSize = true;
            lblValorInventario.BackColor = Color.White;
            lblValorInventario.Location = new Point(368, 8);
            lblValorInventario.Name = "lblValorInventario";
            lblValorInventario.Size = new Size(51, 15);
            lblValorInventario.TabIndex = 2;
            lblValorInventario.Text = "Valor: ₡0";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.White;
            lblCantidad.Location = new Point(190, 8);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(48, 15);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Stock: 0";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.BackColor = Color.White;
            lblProductos.Location = new Point(12, 8);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(73, 15);
            lblProductos.TabIndex = 0;
            lblProductos.Text = "Productos: 0";
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.CustomizableEdges = customizableEdges1;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(257, 54);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox2.Size = new Size(200, 36);
            guna2TextBox2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 241, 252);
            ClientSize = new Size(621, 386);
            Controls.Add(panelContenido);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema De Inventario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label SistemaDeInventario;
        private DataGridView dgvProductos;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox txtBuscar;
        private Panel panelSuperior;
        private Panel panelContenido;
        private Panel panel1;
        private Panel panel2;
        private Label lblValorInventario;
        private Label lblCantidad;
        private Label lblProductos;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    }
}
