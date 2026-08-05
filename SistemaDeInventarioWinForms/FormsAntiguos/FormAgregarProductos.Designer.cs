namespace SistemaDeInventarioWinForms
{
    partial class FormAgregarProductos
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
        public void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(61, 71);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(193, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(61, 141);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 2;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 11F);
            txtCantidad.Location = new Point(193, 135);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 27);
            txtCantidad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(61, 211);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 4;
            label3.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 11F);
            txtPrecio.Location = new Point(193, 205);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 27);
            txtPrecio.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(61, 301);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuardar;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(213, 301);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 376);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAgregarProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Producto";
            Load += FormAgregarProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtCantidad;
        private Label label3;
        private TextBox txtPrecio;
        private Button button1;
        private Button button2;
    }
}