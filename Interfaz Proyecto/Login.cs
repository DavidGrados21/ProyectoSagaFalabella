using Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Interfaz_Proyecto
{
    public partial class Login : Form
    {
        P_Principal p1 = new P_Principal();
        public Login()
        {
            InitializeComponent();
            panelDatos.Visible = false;
            btnIniciarC.Visible = false;
            pictureBox3.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form Admin = new LoginStaff();
            Admin.Show();

            this.Hide();

            Admin.FormClosing += frm_closing;
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            btnAdmin.Visible = false;
            btnCli.Visible = false;
            panelDatos.Visible = true;
            btnIniciarC.Visible = true;
            pictureBox3.Visible = true;
        }

        private void btnIniciarC_Click_1(object sender, EventArgs e)
        {
            string username = txtCorreo.Text;
            string password = txtPasss.Text;
            string nombre = "";



            string connectionString = "Data Source=DESKTOP-S3H7BHS\\SQLEXPRESS;Initial Catalog=SagaFalabella;Integrated Security=True";
            SqlConnection cmx = new SqlConnection(connectionString);

            string query = "SELECT * FROM Clientes WHERE correo_cliente = @Usuario AND dni_cliente = @Contraseña";
            SqlCommand cmd = new SqlCommand(query, cmx);

            string cadena = "SELECT nombre_cliente FROM Clientes WHERE correo_cliente = @Usuario";
            SqlCommand comando = new SqlCommand(cadena, cmx);

            cmd.Parameters.AddWithValue("@Usuario", username);
            cmd.Parameters.AddWithValue("@Contraseña", password);
            comando.Parameters.AddWithValue("@Usuario", username);

            cmx.Open();

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                nombre = lector.GetValue(0).ToString();
            }

            p1.nombre = nombre;

            lector.Close();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                p1.Show();

                this.Hide();

                p1.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseñas Invalido");
            }

            reader.Close();
            cmx.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btnAdmin.Visible = true;
            btnCli.Visible = true;
            panelDatos.Visible = false;
            btnIniciarC.Visible = false;
            pictureBox3.Visible = false;
            btnIniciarC.Visible = false;
        }

        private void btnIniciarC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIniciarC.PerformClick();
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
