    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data.SqlClient;

    namespace Visual
    {
        public partial class Login : Form
        {
            public Login()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario y contraseña de los campos de texto
            string username = txtuser.Text; // Asegúrate de que estos nombres de TextBox coincidan con tu diseño
            string password = txtpassword.Text;

            try
            {
                // Abrir la conexión a la base de datos
                conn.Open();

                // Crear una consulta SQL para verificar las credenciales del usuario
                string query = "SELECT COUNT(1) FROM usuario WHERE nombre=@username AND clave=@password";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Añadir parámetros para evitar SQL Injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                // Ejecutar la consulta
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Si se encontró un usuario con las credenciales ingresadas
                if (count == 1)
                {

                   
                    this.Hide();
                    Dashboard mainForm = new Dashboard(); // Asumiendo que tienes un formulario principal llamado MainForm
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }

        private void lblcambiar_Click(object sender, EventArgs e)
        {
            cambiar cambiar = new cambiar();    
            cambiar.Show();
        }
    }
}
