using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Label = System.Windows.Forms.Label;

namespace CapaDatos
{
    public class Datos
    {
        public Datos(Label lbNombre, Label lbPrecio, string SKU)
        {
            Nombre dbHelper = new Nombre();
            Precio p1 = new Precio();

            lbNombre.Text = dbHelper.GetProductNameBySKU(SKU);
            lbPrecio.Text = "S/." + p1.GetProductNameBySKU(SKU);

            lbNombre.AutoSize = true;
            lbNombre.MaximumSize = new System.Drawing.Size(120, 0);
            lbNombre.TextAlign = (System.Drawing.ContentAlignment)ContentAlignment.Center;
        }
    }

}
