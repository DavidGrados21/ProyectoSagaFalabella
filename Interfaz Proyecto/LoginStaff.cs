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
    public partial class LoginStaff : Form
    {
        public LoginStaff()
        {
            InitializeComponent();
            PDatos.Visible = false;
            btnAdmin.Visible = true;
            btnVend.Visible = true;
            btnISA.Visible = false;
            btnIST.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            PDatos.Visible = true;
            pictureBox2.Visible = true;
            btnISA.Visible = true;
        }

        private void btnVend_Click(object sender, EventArgs e)
        {
            PDatos.Visible = true;
            pictureBox2.Visible = true;
            btnISA.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PDatos.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnISA_Click(object sender, EventArgs e)
        {
            string username = txtCorreo.Text;
            string password = txtPasss.Text;

            string connectionString = "Data Source=DESKTOP-S3H7BHS\\SQLEXPRESS;Initial Catalog=EmpresaFinal2;Integrated Security=True;";
            SqlConnection cmx = new SqlConnection(connectionString);

            string query = "SELECT * FROM Jefes2 WHERE correo_jefe = @Usuario AND codigo_jefe = @Contraseña";
            SqlCommand cmd = new SqlCommand(query, cmx);
            cmd.Parameters.AddWithValue("@Usuario", username);
            cmd.Parameters.AddWithValue("@Contraseña", password);

            cmx.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("BUENAS JEFE");

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseñas Invalido");
            }

            reader.Close();
            cmx.Close();
        }

        private void btnIST_Click(object sender, EventArgs e)
        {
            string username = txtCorreo.Text;
            string password = txtPasss.Text;

            string connectionString = "Data Source=DESKTOP-S3H7BHS\\SQLEXPRESS;Initial Catalog=EmpresaFinal2;Integrated Security=True;";
            SqlConnection cmx = new SqlConnection(connectionString);

            string query = "SELECT * FROM Jefes2 WHERE correo_vendedor = @Usuario AND codigo_vendedor = @Contraseña";
            SqlCommand cmd = new SqlCommand(query, cmx);
            cmd.Parameters.AddWithValue("@Usuario", username);
            cmd.Parameters.AddWithValue("@Contraseña", password);

            cmx.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("BUENAS JEFE");

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseñas Invalido");
            }

            reader.Close();
            cmx.Close();
        }
    }
}
