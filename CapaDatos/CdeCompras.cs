using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CdeCompras
    {
        public List<int> items = new List<int>();
        public void añadir (int sku)
        {
            items.Add (sku);
            MessageBox.Show("El articulo ha sido añadido a tu carrito de compras");
        }

        public void eliminar(int sku)
        {
            items.Remove(sku);
            MessageBox.Show("El articulo ha sido eliminado de tu carrito de compras");
        }

    }
}
