using MySql.Data.MySqlClient;
using System;

namespace PRODUCTOS


{
    public partial class Form1 : Form


    {
        string rutaDB = "Server=localhost;Database=productos_csharp;User ID=root;Password=;";
        private MySqlConnection conexion;
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
                    string query = "INSERT INTO producto (nombre, descripcion, precio) VALUES (@precio, @descripcion, @precio)";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Producto Creado exitosamente");
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

        }
    }
}
