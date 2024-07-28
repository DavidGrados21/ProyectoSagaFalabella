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
    public partial class Electrodomesticos : Form
    {
        ListaIMG listaImg = new ListaIMG();
        CdeCompras cc = new CdeCompras();
        public Electrodomesticos()
        {
            InitializeComponent();
            Catalogo1.Visible = true;
            Opcion1.BackColor = SystemColors.AppWorkspace;
            Catalogo2.Visible = false;
            PanelOpciones.Visible = false;

            RecursoWeb p1 = new RecursoWeb(listaImg.Eimg1, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Eimg2, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Eimg3, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Eimg4, imgP4);
            RecursoWeb p5 = new RecursoWeb(listaImg.Eimg5, imgP5);
            RecursoWeb p6 = new RecursoWeb(listaImg.Eimg6, imgP6);
            RecursoWeb p7 = new RecursoWeb(listaImg.Eimg7, imgP7);
            RecursoWeb p8 = new RecursoWeb(listaImg.Eimg8, imgP8);
            RecursoWeb p9 = new RecursoWeb(listaImg.Eimg9, imgP9);
            RecursoWeb p10 = new RecursoWeb(listaImg.Eimg10, imgP10);
            RecursoWeb p11 = new RecursoWeb(listaImg.Eimg11, imgP11);
            RecursoWeb p12 = new RecursoWeb(listaImg.Eimg12, imgP12);
            RecursoWeb p13 = new RecursoWeb(listaImg.Eimg13, imgP13);
        }

        private void Electrodomesticos_Load(object sender, EventArgs e)
        {
            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "21124589");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "21987463");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "21785647");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "21569784");
            Datos datos5 = new Datos(lbProducto5, lbPrecio5, "21468932");
            Datos datos6 = new Datos(lbProducto6, lbPrecio6, "21598321");
            Datos datos7 = new Datos(lbProducto7, lbPrecio7, "21874532");
            Datos datos8 = new Datos(lbProducto8, lbPrecio8, "21217384");

            Datos datos9 = new Datos(lbProducto9, lbPrecio9, "21948356");
            Datos datos12 = new Datos(lbProducto10, lbPrecio10, "21893071");
            Datos datos13 = new Datos(lbProducto11, lbPrecio11, "21679132");
            Datos datos14 = new Datos(lbProducto12, lbPrecio12, "21627458");
            Datos datos15 = new Datos(lbProducto13, lbPrecio13, "21156892");
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

            Producto2.Visible = true;
            Producto3.Visible = true;
            Producto4.Visible = true;
            Producto5.Visible = true;
            Producto6.Visible = true;
            Producto7.Visible = true;
            Producto8.Visible = true;

            RecursoWeb p1 = new RecursoWeb(listaImg.Eimg1, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Eimg2, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Eimg3, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Eimg4, imgP4);
            RecursoWeb p5 = new RecursoWeb(listaImg.Eimg5, imgP5);
            RecursoWeb p6 = new RecursoWeb(listaImg.Eimg6, imgP6);
            RecursoWeb p7 = new RecursoWeb(listaImg.Eimg7, imgP7);
            RecursoWeb p8 = new RecursoWeb(listaImg.Eimg8, imgP8);
            RecursoWeb p9 = new RecursoWeb(listaImg.Eimg9, imgP9);
            RecursoWeb p10 = new RecursoWeb(listaImg.Eimg10, imgP10);
            RecursoWeb p11 = new RecursoWeb(listaImg.Eimg11, imgP11);
            RecursoWeb p12 = new RecursoWeb(listaImg.Eimg12, imgP12);
            RecursoWeb p13 = new RecursoWeb(listaImg.Eimg13, imgP13);

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "21124589");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "21987463");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "21785647");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "21569784");
            Datos datos5 = new Datos(lbProducto5, lbPrecio5, "21468932");
            Datos datos6 = new Datos(lbProducto6, lbPrecio6, "21598321");
            Datos datos7 = new Datos(lbProducto7, lbPrecio7, "21874532");
            Datos datos8 = new Datos(lbProducto8, lbPrecio8, "21217384");

            Datos datos9 = new Datos(lbProducto9, lbPrecio9, "21948356");
            Datos datos12 = new Datos(lbProducto10, lbPrecio10, "21893071");
            Datos datos13 = new Datos(lbProducto11, lbPrecio11, "21679132");
            Datos datos14 = new Datos(lbProducto12, lbPrecio12, "21627458");
            Datos datos15 = new Datos(lbProducto13, lbPrecio13, "21156892");
        }

        private void lCamara_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "21124589");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "21987463");

            RecursoWeb p1 = new RecursoWeb(listaImg.Eimg1, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Eimg2, imgP2);

            Producto2.Visible = true;
            Producto3.Visible = false;
            Producto4.Visible = false;
            Producto5.Visible = false;
            Producto6.Visible = false;
            Producto7.Visible = false;
            Producto8.Visible = false;
        }

        private void lCelulares_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "21785647");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "21569784");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "21468932");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "21598321");

            RecursoWeb p1 = new RecursoWeb(listaImg.Eimg3, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Eimg4, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Eimg5, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Eimg6, imgP4);

            Producto2.Visible = true;
            Producto3.Visible = true;
            Producto4.Visible = true;
            Producto5.Visible = false;
            Producto6.Visible = false;
            Producto7.Visible = false;
            Producto8.Visible = false;
        }

        private void lLaptop_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "21874532");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "21217384");

            RecursoWeb p1 = new RecursoWeb(listaImg.Eimg7, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Eimg8, imgP2);

            Producto2.Visible = true;
            Producto3.Visible = false;
            Producto4.Visible = false;
            Producto5.Visible = false;
            Producto6.Visible = false;
            Producto7.Visible = false;
            Producto8.Visible = false;
        }

        private void lPantalla_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "21948356");

            RecursoWeb p1 = new RecursoWeb(listaImg.Eimg9, imgP1);

            Producto2.Visible = false;
            Producto3.Visible = false;
            Producto4.Visible = false;
            Producto5.Visible = false;
            Producto6.Visible = false;
            Producto7.Visible = false;
            Producto8.Visible = false;
        }

        private void lvideojuegos_Click(object sender, EventArgs e)
        {
            Opcion1.Visible = false;
            Opcion2.Visible = false;
            label7.Visible = false;

            Catalogo1.Visible = true;
            Catalogo2.Visible = false;

            Datos datos1 = new Datos(lbProducto1, lbPrecio1, "21893071");
            Datos datos2 = new Datos(lbProducto2, lbPrecio2, "21679132");
            Datos datos3 = new Datos(lbProducto3, lbPrecio3, "21627458");
            Datos datos4 = new Datos(lbProducto4, lbPrecio4, "21156892");

            RecursoWeb p1 = new RecursoWeb(listaImg.Eimg10, imgP1);
            RecursoWeb p2 = new RecursoWeb(listaImg.Eimg11, imgP2);
            RecursoWeb p3 = new RecursoWeb(listaImg.Eimg12, imgP3);
            RecursoWeb p4 = new RecursoWeb(listaImg.Eimg13, imgP4);

            Producto2.Visible = true;
            Producto3.Visible = true;
            Producto4.Visible = true;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CdeCompras compras = new CdeCompras(); 
            CarritoDeCompras carritoForm = new CarritoDeCompras(compras); 
            carritoForm.Show();
        }
    }
}
