using CapaDatos;
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

namespace Categorias
{
    public partial class Zapatillas : Form
    {
        ListaIMG listaImg = new ListaIMG();
        CdeCompras cc = new CdeCompras();

        public Zapatillas()
        {
            InitializeComponent();
            Catalogo1.Visible = true;
            Opcion1.BackColor = SystemColors.AppWorkspace;
            Catalogo2.Visible = false;
            PanelOpciones.Visible = false;

            RecursoWeb p1 = new RecursoWeb(listaImg.Zimg1, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Zimg2, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Zimg3, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Zimg4, imgP4);
            RecursoWeb p5 = new RecursoWeb(listaImg.Zimg5, imgP5);
            RecursoWeb p6 = new RecursoWeb(listaImg.Zimg6, imgP6);
            RecursoWeb p7 = new RecursoWeb(listaImg.Zimg7, imgP7);
            RecursoWeb p8 = new RecursoWeb(listaImg.Zimg8, imgP8);
            RecursoWeb p9 = new RecursoWeb(listaImg.Zimg9, imgP9);
            RecursoWeb p10 = new RecursoWeb(listaImg.Zimg10, imgP10);
            RecursoWeb p11 = new RecursoWeb(listaImg.Zimg11, imgP11);
            RecursoWeb p12 = new RecursoWeb(listaImg.Zimg12, imgP12);
            RecursoWeb p13 = new RecursoWeb(listaImg.Zimg13, imgP13);
            RecursoWeb p14 = new RecursoWeb(listaImg.Zimg14, imgP14);
            RecursoWeb p15 = new RecursoWeb(listaImg.Zimg15, imgP15);

        }

        private void Zapatillas_Load(object sender, EventArgs e)
        {
            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "19828986");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "19839520");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "19500609");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "19864660");
            Datos datos5 = new Datos(lbProducto5, lbPrecio5, "19864084");
            Datos datos6 = new Datos(lbProducto6, lbPrecio6, "18573736");
            Datos datos7 = new Datos(lbProducto7, lbPrecio7, "19864308");
            Datos datos8 = new Datos(lbProducto8, lbPrecio8, "19862265");
            Datos datos9 = new Datos(lbProducto9, lbPrecio9, "19617858");
            Datos datos10 = new Datos(lbProducto10, lbPrecio10, "19865164");
            Datos datos11 = new Datos(lbProducto11, lbPrecio11, "17197873");
            Datos datos12 = new Datos(lbProducto12, lbPrecio12, "17197875");
            Datos datos13 = new Datos(lbProducto13, lbPrecio13, "19501033");
            Datos datos14 = new Datos(lbProducto14, lbPrecio14, "19920769");
            Datos datos15 = new Datos(lbProducto15, lbPrecio15, "19510312");

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
            PanelOpciones.Visible = false;
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

            Producto3.Visible = true;
            Producto4.Visible = true;
            Producto5.Visible = true;
            Producto6.Visible = true;
            Producto7.Visible = true;
            Producto8.Visible = true;

            RecursoWeb p1 = new RecursoWeb(listaImg.Zimg1, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Zimg2, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Zimg3, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Zimg4, imgP4);
            RecursoWeb p5 = new RecursoWeb(listaImg.Zimg5, imgP5);
            RecursoWeb p6 = new RecursoWeb(listaImg.Zimg6, imgP6);
            RecursoWeb p7 = new RecursoWeb(listaImg.Zimg7, imgP7);
            RecursoWeb p8 = new RecursoWeb(listaImg.Zimg8, imgP8);
            RecursoWeb p9 = new RecursoWeb(listaImg.Zimg9, imgP9);
            RecursoWeb p10 = new RecursoWeb(listaImg.Zimg10, imgP10);
            RecursoWeb p11 = new RecursoWeb(listaImg.Zimg11, imgP11);
            RecursoWeb p12 = new RecursoWeb(listaImg.Zimg12, imgP12);
            RecursoWeb p13 = new RecursoWeb(listaImg.Zimg13, imgP13);
            RecursoWeb p14 = new RecursoWeb(listaImg.Zimg14, imgP14);
            RecursoWeb p15 = new RecursoWeb(listaImg.Zimg15, imgP15);

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "19828986");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "19839520");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "19500609");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "19864660");
            Datos datos5 = new Datos(lbProducto5, lbPrecio5, "19864084");
            Datos datos6 = new Datos(lbProducto6, lbPrecio6, "18573736");
            Datos datos7 = new Datos(lbProducto7, lbPrecio7, "19864308");
            Datos datos8 = new Datos(lbProducto8, lbPrecio8, "19862265");
            Datos datos9 = new Datos(lbProducto9, lbPrecio9, "19617858");
            Datos datos10 = new Datos(lbProducto10, lbPrecio10, "19865164");
            Datos datos11 = new Datos(lbProducto11, lbPrecio11, "17197873");
            Datos datos12 = new Datos(lbProducto12, lbPrecio12, "17197875");
            Datos datos13 = new Datos(lbProducto13, lbPrecio13, "19501033");
            Datos datos14 = new Datos(lbProducto14, lbPrecio14, "19920769");
            Datos datos15 = new Datos(lbProducto15, lbPrecio15, "19510312");
        }

        private void lAdidas_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "19828986");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "19839520");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "19500609");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "19501033");
            Datos datos5 = new Datos(lbProducto5, lbPrecio5, "19510312");

            RecursoWeb p1 = new RecursoWeb(listaImg.Zimg1, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Zimg2, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Zimg3, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Zimg13, imgP4);
            RecursoWeb p5 = new RecursoWeb(listaImg.Zimg14, imgP5);

            Producto2.Visible = true;
            Producto3.Visible = true;
            Producto4.Visible = true;
            Producto5.Visible = true;
            Producto6.Visible = false;
            Producto7.Visible = false;
            Producto8.Visible = false;
        }

        private void lPuma_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "19864308");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "19862265");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "19617858");

            RecursoWeb p1 = new RecursoWeb(listaImg.Zimg7, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Zimg8, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Zimg9, imgP3);

            Producto2.Visible = true;
            Producto3.Visible = true;
            Producto4.Visible = false;
            Producto5.Visible = false;
            Producto6.Visible = false;
            Producto7.Visible = false;
            Producto8.Visible = false;
        }

        private void lReebook_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "17197873");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "17197875");

            RecursoWeb p1 = new RecursoWeb(listaImg.Zimg11, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Zimg12, imgP2);


            Producto3.Visible = false;
            Producto4.Visible = false;
            Producto5.Visible = false;
            Producto6.Visible = false;
            Producto7.Visible = false;
            Producto8.Visible = false;
        }

        private void lOtros_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "19864660");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "19864084");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "18573736");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "19865164");
            Datos datos5 = new Datos(lbProducto5, lbPrecio5, "19920769");

            RecursoWeb p1 = new RecursoWeb(listaImg.Zimg4, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Zimg5, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Zimg6, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Zimg10, imgP4);
            RecursoWeb p5 = new RecursoWeb(listaImg.Zimg15, imgP5);

            Producto3.Visible = true;
            Producto4.Visible = true;
            Producto5.Visible = true;
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

        private void lbProducto12_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto12.Text);
            cc.añadir(SKU);
        }

        private void lbProducto13_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto13.Text);
            cc.añadir(SKU);
        }

        private void lbProducto14_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto14.Text);
            cc.añadir(SKU);
        }

        private void lbProducto15_Click(object sender, EventArgs e)
        {
            ConsultaNombre consultaNombre = new ConsultaNombre();
            int SKU = consultaNombre.GetProductNameBySKU(lbProducto15.Text);
            cc.añadir(SKU);
        }


    }
}
