using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Nombre
    {
        private string connectionString = "Data Source=DESKTOP-S3H7BHS\\SQLEXPRESS;Initial Catalog=SagaFalabella;Integrated Security=True;";

        public string GetProductNameBySKU(string sku)
        {
            string productName = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT nombre_producto FROM Productos WHERE SKU = @SKU";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SKU", sku);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            productName = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones según sea necesario.
                Console.WriteLine("Error: " + ex.Message);
            }

            return productName;
        }
    }

}
