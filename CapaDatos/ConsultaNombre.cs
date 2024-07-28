using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConsultaNombre
    {
        private string connectionString = "Data Source=DESKTOP-S3H7BHS\\SQLEXPRESS;Initial Catalog=SagaFalabella;Integrated Security=True;";

        public int GetProductNameBySKU(string nombre)
        {
            int SKU = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SKU FROM Productos WHERE nombre_producto = @nombre";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        object result = cmd.ExecuteScalar();

                        if (result != null) 
                        { 
                            SKU = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones según sea necesario.
                Console.WriteLine("Error: " + ex.Message);
            }

            return SKU;
        }
    }
}
