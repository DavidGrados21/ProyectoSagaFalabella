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

namespace Categorias
{
    public partial class Perfumeria : Form
    {
        ListaIMG listaImg = new ListaIMG();
        CdeCompras cc = new CdeCompras();
        public Perfumeria()
        {
            InitializeComponent();
            Catalogo1.Visible = true;
            Opcion1.BackColor = SystemColors.AppWorkspace;
            Catalogo2.Visible = false;
            PanelOpciones.Visible = false;

            RecursoWeb p1 = new RecursoWeb(listaImg.Pimg1, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Pimg2, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Pimg3, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Pimg4, imgP4);
            RecursoWeb p5 = new RecursoWeb(listaImg.Pimg5, imgP5);
            RecursoWeb p6 = new RecursoWeb(listaImg.Pimg6, imgP6);
            RecursoWeb p7 = new RecursoWeb(listaImg.Pimg7, imgP7);
            RecursoWeb p8 = new RecursoWeb(listaImg.Pimg8, imgP8);
            RecursoWeb p9 = new RecursoWeb(listaImg.Pimg9, imgP9);
            RecursoWeb p10 = new RecursoWeb(listaImg.Pimg10, imgP10);
            RecursoWeb p11 = new RecursoWeb(listaImg.Pimg11, imgP11);
        }

        private void Perfumeria_Load(object sender, EventArgs e)
        {
            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "16436099");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "18808310");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "17681471");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "18804947");
            Datos datos5 = new Datos(lbProducto5, lbPrecio5, "18047543");
            Datos datos6 = new Datos(lbProducto6, lbPrecio6, "20006242");
            Datos datos7 = new Datos(lbProducto7, lbPrecio7, "18413091");
            Datos datos8 = new Datos(lbProducto8, lbPrecio8, "12316823");

            Datos datos9 = new Datos(lbProducto9, lbPrecio9, "19956169");
            Datos datos12 = new Datos(lbProducto10, lbPrecio10, "18751809");
            Datos datos13 = new Datos(lbProducto11, lbPrecio11, "18808281");

        }

        private void Opcion1_Click(object sender, EventArgs e)
        {
            Opcion2.BackColor = Color.SeaShell;
            Opcion1.BackColor = SystemColors.AppWorkspace;
            Catalogo1.Visible = true;
            Catalogo2.Visible = false;
        }

        private void Opcion2_Click(object sender, EventArgs e)
        {
            Opcion1.BackColor = Color.SeaShell;
            Opcion2.BackColor = SystemColors.AppWorkspace;
            Catalogo2.Visible = true;
            Catalogo1.Visible = false;
        }

        private void label58_Click(object sender, EventArgs e)
        {
            PanelOpciones.Visible = true;
        }

        private void label58_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PanelOpciones.Visible = false;

            Opcion1.Visible = true;
            Opcion2.Visible = true;
            label7.Visible = true;

            Producto5.Visible = true;
            Producto6.Visible = true;
            Producto7.Visible = true;
            Producto8.Visible = true;

            RecursoWeb p1 = new RecursoWeb(listaImg.Pimg1, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Pimg2, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Pimg3, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Pimg4, imgP4);
            RecursoWeb p5 = new RecursoWeb(listaImg.Pimg5, imgP5);
            RecursoWeb p6 = new RecursoWeb(listaImg.Pimg6, imgP6);
            RecursoWeb p7 = new RecursoWeb(listaImg.Pimg7, imgP7);
            RecursoWeb p8 = new RecursoWeb(listaImg.Pimg8, imgP8);
            RecursoWeb p9 = new RecursoWeb(listaImg.Pimg9, imgP9);
            RecursoWeb p10 = new RecursoWeb(listaImg.Pimg10, imgP10);
            RecursoWeb p11 = new RecursoWeb(listaImg.Pimg11, imgP11);

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "16436099");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "18808310");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "17681471");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "18804947");
            Datos datos5 = new Datos(lbProducto5, lbPrecio5, "18047543");
            Datos datos6 = new Datos(lbProducto6, lbPrecio6, "20006242");
            Datos datos7 = new Datos(lbProducto7, lbPrecio7, "18413091");
            Datos datos8 = new Datos(lbProducto8, lbPrecio8, "12316823");

            Datos datos9 = new Datos(lbProducto9, lbPrecio9, "19956169");
            Datos datos12 = new Datos(lbProducto10, lbPrecio10, "18751809");
            Datos datos13 = new Datos(lbProducto11, lbPrecio11, "18808281");
        }

        private void lPColeccion_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            RecursoWeb p1 = new RecursoWeb(listaImg.Pimg1, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Pimg2, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Pimg3, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Pimg4, imgP4);
            RecursoWeb p5 = new RecursoWeb(listaImg.Pimg5, imgP5);
            RecursoWeb p6 = new RecursoWeb(listaImg.Pimg6, imgP6);
            RecursoWeb p7 = new RecursoWeb(listaImg.Pimg7, imgP7);

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "16436099");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "18808310");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "17681471");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "18804947");
            Datos datos5 = new Datos(lbProducto5, lbPrecio5, "18047543");
            Datos datos6 = new Datos(lbProducto6, lbPrecio6, "20006242");
            Datos datos7 = new Datos(lbProducto7, lbPrecio7, "18413091");

            Producto5.Visible = true;
            Producto6.Visible = true;
            Producto7.Visible = true;
            Producto8.Visible = false;
        }

        private void lPTemporada_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            RecursoWeb p1 = new RecursoWeb(listaImg.Pimg8, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Pimg9, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Pimg10, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Pimg11, imgP4);

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "12316823");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "19956169");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "18751809");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "18808281");

            Producto5.Visible = false;
            Producto6.Visible = false;
            Producto7.Visible = false;
            Producto8.Visible = false;
        }

        private void lbProducto1_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto1.Text);
            cc.añadir(SKU);
        }

        private void lbProducto2_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto2.Text);
            cc.añadir(SKU);
        }

        private void lbProducto3_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto3.Text);
            cc.añadir(SKU);
        }

        private void lbProducto4_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto4.Text);
            cc.añadir(SKU);
        }

        private void lbProducto5_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto5.Text);
            cc.añadir(SKU);
        }

        private void lbProducto6_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto6.Text);
            cc.añadir(SKU);
        }

        private void lbProducto7_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto7.Text);
            cc.añadir(SKU);
        }

        private void lbProducto8_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto8.Text);
            cc.añadir(SKU);
        }

        private void lbProducto9_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto9.Text);
            cc.añadir(SKU);
        }

        private void lbProducto10_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto10.Text);
            cc.añadir(SKU);
        }

        private void lbProducto11_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto11.Text);
            cc.añadir(SKU);
        }
    }
}
