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
            Editar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
<<<<<<< HEAD
=======
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            txtNombre.Location = new Point(52, 26);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del Producto";
<<<<<<< HEAD
            txtNombre.Size = new Size(97, 23);
=======
            txtNombre.Size = new Size(97, 25);
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
<<<<<<< HEAD
=======
            txtDescripcion.BackColor = SystemColors.InactiveCaption;
            txtDescripcion.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            txtDescripcion.Location = new Point(52, 75);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
<<<<<<< HEAD
            txtDescripcion.Size = new Size(97, 23);
=======
            txtDescripcion.Size = new Size(97, 25);
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            txtDescripcion.TabIndex = 1;
            // 
            // txtPrecio
            // 
<<<<<<< HEAD
=======
            txtPrecio.BackColor = SystemColors.InactiveCaption;
            txtPrecio.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecio.ForeColor = SystemColors.InactiveCaptionText;
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            txtPrecio.Location = new Point(52, 124);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
<<<<<<< HEAD
            txtPrecio.Size = new Size(97, 23);
=======
            txtPrecio.Size = new Size(97, 25);
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            txtPrecio.TabIndex = 2;
            // 
            // Crear
            // 
<<<<<<< HEAD
            Crear.Location = new Point(39, 164);
            Crear.Margin = new Padding(3, 2, 3, 2);
            Crear.Name = "Crear";
            Crear.Size = new Size(124, 32);
=======
            Crear.BackColor = SystemColors.ActiveCaption;
            Crear.Font = new Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Crear.ForeColor = SystemColors.ActiveCaptionText;
            Crear.Location = new Point(52, 169);
            Crear.Margin = new Padding(3, 2, 3, 2);
            Crear.Name = "Crear";
            Crear.Size = new Size(96, 27);
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            Crear.TabIndex = 3;
            Crear.Text = "Crear producto";
            Crear.UseVisualStyleBackColor = false;
            Crear.Click += Crear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 35);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(262, 141);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Eliminar
            // 
<<<<<<< HEAD
=======
            Eliminar.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            Eliminar.Location = new Point(296, 218);
            Eliminar.Margin = new Padding(3, 2, 3, 2);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(124, 32);
            Eliminar.TabIndex = 5;
            Eliminar.Text = "Eliminar producto";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // Editar
            // 
<<<<<<< HEAD
=======
            Editar.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            Editar.Location = new Point(434, 218);
            Editar.Margin = new Padding(3, 2, 3, 2);
            Editar.Name = "Editar";
            Editar.Size = new Size(124, 32);
            Editar.TabIndex = 6;
            Editar.Text = "Editar producto";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(69, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 7;
            button1.Text = "Probar conexión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = SystemColors.ControlLightLight;
=======
            BackColor = SystemColors.Info;
>>>>>>> dcc742a6c0baa3b043744b167fae8babd3230a69
            ClientSize = new Size(612, 254);
            Controls.Add(button1);
            Controls.Add(Editar);
            Controls.Add(Eliminar);
            Controls.Add(dataGridView1);
            Controls.Add(Crear);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Configuración de Productos";
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
        private Button Editar;
        private Button button1;
    }
}
