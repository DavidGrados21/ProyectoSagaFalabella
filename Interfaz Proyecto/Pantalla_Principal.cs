using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Proyecto
{
    public partial class Pantalla_Principal : Form
    {
        public Pantalla_Principal()
        {
            InitializeComponent();
            PanelSesion.Visible = false;
            imgConectado.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                imgConectado.Visible = true;
                MoatrarConectado.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                imgConectado.Visible = false;
                MoatrarConectado.Enabled = false; 
            }
        }
        private void btnInciarSesion_Click(object sender, EventArgs e)
        {
            Form iniciar = new Login();
            iniciar.Show();
            PanelSesion.Visible = false;
            this.Hide();

            iniciar.FormClosing += frm_closing;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PanelSesion.Visible = true;
        }

        private void MoatrarConectado_Tick(object sender, EventArgs e)
        {
            imgConectado.Visible = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.GreenYellow;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form reg = new Registrarse();
            reg.Show();
            this.Hide();

            reg.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
