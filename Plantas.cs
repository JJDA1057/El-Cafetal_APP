using El_Cafetal_APP.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Cafetal_APP
{
    public partial class Plantas : Form
    {
        public Plantas()
        {
            InitializeComponent();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarPlantasAsync();
        }

        private async Task CargarPlantasAsync()
        {
            
        }


        private void ConfigurarDataGridView()
        {
            // Limpiar columnas existentes
            dataGridView1.Columns.Clear();
        }

            // Configurar propiedades básicas del DataGridView



        private void button2_Click(object sender, EventArgs e)
        {

            this.Close(); // Cierra Semillas
        }

    }
}
