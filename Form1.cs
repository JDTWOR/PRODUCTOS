using MySql.Data.MySqlClient;


namespace PRODUCTOS


{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = "Server=localhost;Database=producto;User ID=root;Password=;SslMode=none;";

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
    }
}
