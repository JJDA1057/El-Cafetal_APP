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
    public partial class AgregarCultivo : Form
    {
        public AgregarCultivo()
        {
            InitializeComponent();
        }

        private void btnCultivo_Click(object sender, EventArgs e)
        {
            NuevoCultivo cultivo = new NuevoCultivo();
            this.Hide();
            cultivo.Show();
            this.Show();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            this.Show();

        }

        private void btnPlanta_Click(object sender, EventArgs e)
        {
            AgregarPlanta pl = new AgregarPlanta();
            this.Hide();
            pl.Show();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Pedidos ped = new Pedidos())
                {
                    this.Hide(); // Oculta Inventario
                    ped.ShowDialog(); // Muestra pagina como modal
                    this.Show(); // Al cerrar Semillas, vuelve a mostrar Inventario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLote_Click(object sender, EventArgs e)
        {
            AgregarLote lt= new AgregarLote();
            this.Hide();
            lt.Show();
            this.Show();
        }
    }
}
