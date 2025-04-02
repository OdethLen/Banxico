using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banxico
{
    public partial class automobile : Form
    {
        private DataTable dataTable = new DataTable();
        public automobile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv files |*.csv";
            openFileDialog.Title = "Open csv file";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string filePath = openFileDialog.FileName;
            LoadCSV(filePath);
        }


        private void LoadCSV(string filePath)
        {
            try
            {
                dataTable.Clear();
                dataTable.Columns.Clear();

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length == 0) return;

                // Leer encabezados
                string[] headers = lines[0].Split(',');
                foreach (string header in headers)
                    dataTable.Columns.Add(header.Trim());

                // Leer datos
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] row = lines[i].Split(',');
                    dataTable.Rows.Add(row);
                }

                dgvCars.DataSource = dataTable;

                // Llenar ComboBox con marcas únicas de la columna "make"
                cmbCars.Items.Clear();
                cmbCars.Items.Add("Todos"); // Opción para mostrar todos
                cmbCars.Items.AddRange(dataTable.AsEnumerable()
                    .Select(row => row["make"].ToString()) // Filtrar por la columna "make"
                    .Distinct()
                    .OrderBy(make => make)
                    .ToArray());

                cmbCars.SelectedIndex = 0; // Seleccionar "Todos" por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message);
            }
        }

        private void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCars.SelectedItem == null || dataTable.Rows.Count == 0)
                return;

            string selectedBrand = cmbCars.SelectedItem.ToString();
            if (selectedBrand == "Todos")
            {
                dgvCars.DataSource = dataTable;
            }
            else
            {
                DataView filteredView = new DataView(dataTable);
                filteredView.RowFilter = $"make = '{selectedBrand}'"; // Filtrar por "make"
                dgvCars.DataSource = filteredView;
            }
        }

        private void automobile_Load(object sender, EventArgs e)
        {

        }
    }
}
