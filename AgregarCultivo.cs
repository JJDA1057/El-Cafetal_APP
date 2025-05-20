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
    }
}
