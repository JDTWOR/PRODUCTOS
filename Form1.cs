using MySql.Data.MySqlClient;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRODUCTOS


{
    public partial class Form1 : Form


    {
        string rutaDB = "Server=localhost;Database=productos_csharp;User ID=root;Password=1234";
        private MySqlConnection conexion;
        string txtId;
        public Form1()
        {
            InitializeComponent();
            MostrarProductos();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string pre = txtPrecio.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(pre))
            {
                MessageBox.Show("Ingrese todos los datos");
                return;
            }

            if (!double.TryParse(pre, out double precio))
            {
                MessageBox.Show("El precio debe ser un número válido");
                return;
            }

            try
            {
                using (var conexion = new MySqlConnection(rutaDB))
                {
                    conexion.Open();
                    string query = "INSERT INTO producto (nombre, descripcion, precio) VALUES (@nombre, @descripcion, @precio)";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Producto creado exitosamente");
                MostrarProductos();
            }
            catch
            {
                MessageBox.Show("Error al crear el producto. Verifique los datos ingresados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = "Server=localhost;Database=productos_csharp;User ID=root;Password=1234;";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Conexión exitosa a MySQL");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void MostrarProductos()
        {
            try
            {
                conexion = new MySqlConnection(rutaDB);
                conexion.Open();
                string query = "SELECT * FROM producto";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["descripcion"].Value.ToString();
                txtPrecio.Text = row.Cells["precio"].Value.ToString();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            conexion = new MySqlConnection(rutaDB);
            conexion.Open();
            string query = "DELETE FROM producto WHERE id=@id";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", txtId);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Producto eliminado con exito: ");
            MostrarProductos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            var idCell = dataGridView1.SelectedRows[0].Cells["id"].Value;
            txtId = idCell.ToString();
            txtNombre.Text = row.Cells["nombre"].Value?.ToString();
            txtDescripcion.Text = row.Cells["descripcion"].Value?.ToString();
            txtPrecio.Text = row.Cells["precio"].Value?.ToString();

        }
    }
}

