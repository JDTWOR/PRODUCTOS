namespace PRODUCTOS
{
    partial class Form1
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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            Crear = new Button();
            dataGridView1 = new DataGridView();
            Eliminar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(67, 89);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(67, 151);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 2;
            // 
            // Crear
            // 
            Crear.Location = new Point(60, 228);
            Crear.Name = "Crear";
            Crear.Size = new Size(142, 42);
            Crear.TabIndex = 3;
            Crear.Text = "Crear producto";
            Crear.UseVisualStyleBackColor = true;
            Crear.Click += Crear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(338, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 4;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(338, 291);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(142, 42);
            Eliminar.TabIndex = 5;
            Eliminar.Text = "Eliminar producto";
            Eliminar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(496, 291);
            button2.Name = "button2";
            button2.Size = new Size(142, 42);
            button2.TabIndex = 6;
            button2.Text = "Editar producto";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Eliminar);
            Controls.Add(dataGridView1);
            Controls.Add(Crear);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private Button Crear;
        private DataGridView dataGridView1;
        private Button Eliminar;
        private Button button2;
    }
}
