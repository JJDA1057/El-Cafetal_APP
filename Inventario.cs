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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Semillas semillas = new Semillas())
                {
                    this.Hide(); // Oculta Inventario
                    semillas.ShowDialog(); // Muestra Semillas como modal
                    this.Show(); // Al cerrar Semillas, vuelve a mostrar Inventario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (Plantas plantas = new Plantas())
                {
                    this.Hide(); // Oculta Inventario
                    plantas.ShowDialog(); // Muestra Semillas como modal
                    this.Show(); // Al cerrar Semillas, vuelve a mostrar Inventario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                using (Nutrientes nutri = new Nutrientes())
                {
                    this.Hide(); // Oculta Inventario
                    nutri.ShowDialog(); // Muestra Semillas como modal
                    this.Show(); // Al cerrar Semillas, vuelve a mostrar Inventario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
