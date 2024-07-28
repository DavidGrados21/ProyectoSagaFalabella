using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Interfaz_Proyecto;

namespace Categorias
{
    public partial class P_Principal : Form
    {
        public string nombre = "";

        public P_Principal()
        {
           InitializeComponent();
            panel1.Visible = false;

        }

        private void P_Principal_Load(object sender, EventArgs e)
        {
           Tbarra.Start();
           label7.Text = "Bienvenido/a " + nombre;
        }

        private void Tbarra_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            BPClientes.Value += 1;
            if (BPClientes.Value == 100)
            {
                Tbarra.Stop();
                BPClientes.Visible = false;
                label7.Visible = false;
                panel1.Visible = true;

            }
        }

        private void falabella_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.falabella.com.pe");
        }

        private void sodimac_Click(object sender, EventArgs e)
        {
            Process.Start("https://sodimac.falabella.com.pe");
        }

        private void tottus_Click(object sender, EventArgs e)
        {
            Process.Start("https://tottus.falabella.com.pe");
        }

        private void linio_Click(object sender, EventArgs e)
        {
            Process.Start("https://linio.falabella.com.pe");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form calzado = new Zapatillas();
            calzado.Show();
            this.Hide();

            calzado.FormClosing += frm_closing;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form electro = new Electrodomesticos();
            electro.Show();
            this.Hide();

            electro.FormClosing += frm_closing;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form ropa = new Textil();
            ropa.Show();
            this.Hide();

            ropa.FormClosing += frm_closing;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form colonia = new Perfumeria();
            colonia.Show();

            this.Hide();

            colonia.FormClosing += frm_closing;
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
