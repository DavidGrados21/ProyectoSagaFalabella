using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class RecursoWeb
    {
        public RecursoWeb(string link, PictureBox img)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    byte[] data = webClient.DownloadData(link);

                    // Convierte los datos descargados en una imagen
                    using (System.IO.MemoryStream mem = new System.IO.MemoryStream(data))
                    {
                        img.Image = System.Drawing.Image.FromStream(mem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al descargar la imagen: {ex.Message}");
                }
            }
        }
    }
}







