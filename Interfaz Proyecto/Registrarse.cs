using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Proyecto
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Correo = txtCorreo.Text;
            string Edad = txtEdad.Text;
            string Pass = txtPass.Text;

            if (Nombre == "" || Correo == "" || Edad == "" || Pass == "")
            {
                MessageBox.Show("Por favor rellenar todos los campos");
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtEdad.Text = "";
                txtPass.Text = "";
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-S3H7BHS\\SQLEXPRESS;Initial Catalog=SagaFalabella;Integrated Security=True;";
                SqlConnection cmx = new SqlConnection(connectionString);


                cmx.Open();

                string query = "INSERT INTO Clientes (nombre_cliente, correo_cliente, dni_cliente, edad_cliente) VALUES (@Nombre, @Correo, @Pass, @Edad)";

                using (SqlCommand cmd = new SqlCommand(query, cmx))
                {
                    // Agrega los parámetros y sus valores
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Correo", Correo);
                    cmd.Parameters.AddWithValue("@Pass", Pass);
                    cmd.Parameters.AddWithValue("@Edad", Edad);

                    int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta la consulta
                }

                MessageBox.Show("Usuario registrado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
