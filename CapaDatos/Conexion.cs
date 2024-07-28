using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Interfaz_Proyecto
{
    public class Conexion
    {
        private SqlConnection cmx;
        public Conexion()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-S3H7BHS\\SQLEXPRESS;Initial Catalog=SagaFalabella;Integrated Security=True;";
                cmx = new SqlConnection(connectionString);
                cmx.Open();

            } 
            catch (Exception e)
            {
                MessageBox.Show("Error " +e.Message, "Error inesperado", MessageBoxButtons.OK);
            }
        }
    }
}
