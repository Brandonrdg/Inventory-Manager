namespace SistemaDeInventarioWinForms
{
    partial class FormActualizarProductos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(35, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(35, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 205);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 2;
            label3.Text = "Precio:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(223, 147);
            txtCantidad.Margin = new Padding(4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 29);
            txtCantidad.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(223, 197);
            txtPrecio.Margin = new Padding(4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 29);
            txtPrecio.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(90, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 6;
            label4.Text = "Editar Producto";
            // 
            // button2
            // 
            button2.Location = new Point(35, 271);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(96, 32);
            button2.TabIndex = 8;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnActualizar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(227, 271);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(96, 32);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(223, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 29);
            txtNombre.TabIndex = 10;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // FormActualizarProductos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 320);
            Controls.Add(txtNombre);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FormActualizarProductos";
            Text = "FormActualizarProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Label label4;
        private Button button2;
        private Button button3;
        private TextBox txtNombre;
    }
}