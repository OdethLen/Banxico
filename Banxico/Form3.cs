using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace Banxico
{
    public partial class Form3 : Form
    {
        private readonly string token = "0f93540aea22cc07f4a7980bf5a9621fd367932498b7a62fdd0d021318d644dd";

        public Form3()
        {
            InitializeComponent();
        }

        private  async void btnShow_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpStartDate.Value.Date;
            DateTime fechaFin = dtpEndDate.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método asíncrono correctamente
            await ObtenerDolarPorFechas(fechaInicio.ToString("yyyy-MM-dd"), fechaFin.ToString("yyyy-MM-dd"));
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpStartDate.Format = DateTimePickerFormat.Custom;
            //dtpStartDate.CustomFormat = "yyyy/MM/dd";

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpEndDate.Format = DateTimePickerFormat.Custom;
            //dtpEndDate.CustomFormat = "yyyy/MM/dd";

        }

        private async Task ObtenerDolarPorFechas(string fechaInicio, string fechaFin)
        {
            string url = $"https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/{fechaInicio}/{fechaFin}?token={token}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JObject datos = JObject.Parse(jsonResponse);

                    // Verificar si los datos están presentes
                    var series = datos["bmx"]?["series"]?[0]?["datos"];
                    if (series == null || series.Count() == 0)
                    {
                        MessageBox.Show("No se encontraron datos para el rango de fechas seleccionado.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Limpiar filas previas antes de agregar nuevos datos
                    dgvData.Rows.Clear();

                    // Recorrer los datos y agregarlos al DataGridView
                    foreach (var dato in series)
                    {
                        // El formato correcto de la fecha desde la API es 'yyyy-MM-dd'
                        string fechaApi = dato["fecha"].ToString();

                        // Convierte la fecha de la API al formato correcto
                        DateTime fecha = DateTime.ParseExact(fechaApi, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                        // Formatea la fecha a 'dd/MM/yyyy' para mostrar en el DataGridView
                        string fechaFormateada = fecha.ToString("dd/MM/yyyy");

                        string valor = dato["dato"].ToString();
                        dgvData.Rows.Add(fechaFormateada, valor);
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener los datos de Banxico. Código de error: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
