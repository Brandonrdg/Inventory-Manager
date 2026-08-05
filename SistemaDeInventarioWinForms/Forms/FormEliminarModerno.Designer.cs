namespace SistemaDeInventarioWinForms.Forms
{
    partial class FormEliminarModerno
    {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvProductoEliminar = new Guna.UI2.WinForms.Guna2DataGridView();
            Tittle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductoEliminar).BeginInit();
            SuspendLayout();
            // 
            // dgvProductoEliminar
            // 
            dgvProductoEliminar.AllowUserToAddRows = false;
            dgvProductoEliminar.AllowUserToDeleteRows = false;
            dgvProductoEliminar.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvProductoEliminar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductoEliminar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductoEliminar.ColumnHeadersHeight = 22;
            dgvProductoEliminar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProductoEliminar.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductoEliminar.GridColor = Color.FromArgb(231, 229, 255);
            dgvProductoEliminar.Location = new Point(12, 91);
            dgvProductoEliminar.MultiSelect = false;
            dgvProductoEliminar.Name = "dgvProductoEliminar";
            dgvProductoEliminar.ReadOnly = true;
            dgvProductoEliminar.RowHeadersVisible = false;
            dgvProductoEliminar.ScrollBars = ScrollBars.None;
            dgvProductoEliminar.Size = new Size(360, 75);
            dgvProductoEliminar.TabIndex = 0;
            dgvProductoEliminar.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvProductoEliminar.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvProductoEliminar.ThemeStyle.HeaderStyle.Height = 22;
            dgvProductoEliminar.ThemeStyle.ReadOnly = true;
            dgvProductoEliminar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvProductoEliminar.ThemeStyle.RowsStyle.Height = 25;
            // 
            // Tittle
            // 
            Tittle.BackColor = Color.Transparent;
            Tittle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Tittle.ForeColor = Color.FromArgb(250, 250, 250);
            Tittle.Location = new Point(148, 9);
            Tittle.Margin = new Padding(0);
            Tittle.Name = "Tittle";
            Tittle.Size = new Size(83, 32);
            Tittle.TabIndex = 1;
            Tittle.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.BorderRadius = 8;
            btnEliminar.CustomizableEdges = customizableEdges1;
            btnEliminar.DisabledState.BorderColor = Color.DarkGray;
            btnEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEliminar.FillColor = Color.FromArgb(220, 38, 38);
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.HoverState.FillColor = Color.FromArgb(185, 28, 28);
            btnEliminar.Location = new Point(12, 225);
            btnEliminar.Margin = new Padding(30);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEliminar.Size = new Size(174, 30);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BorderRadius = 8;
            btnEditar.CustomizableEdges = customizableEdges3;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.White;
            btnEditar.FillColor = Color.Black;
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ForeColor = Color.White;
            btnEditar.HoverState.FillColor = Color.FromArgb(29, 78, 216);
            btnEditar.Location = new Point(198, 225);
            btnEditar.Margin = new Padding(30);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditar.Size = new Size(174, 30);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Cancelar";
            btnEditar.Click += btnEditar_Click;
            // 
            // FormEliminarModerno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 63, 70);
            ClientSize = new Size(384, 286);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(Tittle);
            Controls.Add(dgvProductoEliminar);
            Name = "FormEliminarModerno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEliminarModerno";
            ((System.ComponentModel.ISupportInitialize)dgvProductoEliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvProductoEliminar;
        private Guna.UI2.WinForms.Guna2HtmlLabel Tittle;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
    }
}