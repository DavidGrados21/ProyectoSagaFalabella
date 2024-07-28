using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categorias
{
    public partial class CarritoDeCompras : Form
    {
        public string nombreSD;

        public List<int> productos = new List<int>();
        private CdeCompras compras = new CdeCompras();

        Nombre dbHelper = new Nombre();
        Precio p1 = new Precio();

        public CarritoDeCompras(CdeCompras compras)
        {
            InitializeComponent();
            this.compras = compras;
            productos.AddRange(compras.items);
        }

        private void CarritoDeCompras_Load(object sender, EventArgs e)
        {
            label7.Text = "Bienvenido/a " + nombreSD;

            // Configurar ListView con las especificaciones dadas
            CarritoC.Size = new System.Drawing.Size(548, 258);
            CarritoC.TabIndex = 0;
            CarritoC.View = System.Windows.Forms.View.Details;
            CarritoC.MultiSelect = true;
            CarritoC.HideSelection = false;
            CarritoC.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            // Configurar columnas del ListView
            ColumnHeader columnHeaderl = new ColumnHeader();
            columnHeaderl.Text = "SKU";
            columnHeaderl.TextAlign = HorizontalAlignment.Left;
            columnHeaderl.Width = 91;

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "NOMBRE";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 345;

            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "PRECIO"; // Corregido el número de columna y el texto
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 112;

            CarritoC.Columns.Add(columnHeaderl);
            CarritoC.Columns.Add(columnHeader2);
            CarritoC.Columns.Add(columnHeader3);

            foreach (int producto in productos)
            {
                string productoStr = producto.ToString();

                string nombre = dbHelper.GetProductNameBySKU(productoStr);
                string precio = p1.GetProductNameBySKU(productoStr);

                ListViewItem item = new ListViewItem(producto.ToString());
                item.SubItems.Add(nombre);
                item.SubItems.Add(precio.ToString());

                CarritoC.Items.Add(item);
            }
        }
    }
}
