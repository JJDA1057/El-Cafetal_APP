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
    public partial class AñadirPlantas : Form
    {
        public AñadirPlantas()
        {
            InitializeComponent();
        }

        public class Planta
        {
            public int ID_planta { get; set; }
            public int id_lote { get; set; }
            public DateTime fecha_plantacion { get; set; }
            public string estado { get; set; }
            public string observaciones { get; set; }

        }

        public List<Planta> plantas = new List<Planta>();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AñadirPlantas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtLote.Text = dataviewDatos.CurrentRow.Cells[0].Value.ToString();
                txtPlanta_name.Text = dataviewDatos.CurrentRow.Cells[1].Value.ToString();
                txtFecha.Text = dataviewDatos.CurrentRow.Cells[2].Value.ToString();
                txtEstado.Text = dataviewDatos.CurrentRow.Cells[3].Value.ToString();
                txtObserva.Text = dataviewDatos.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Los Datos no pudieron ser almacenados " + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtLote.Text) ||
                    string.IsNullOrEmpty(txtPlanta_name.Text) ||
                    string.IsNullOrEmpty(txtFecha.Text) ||
                    string.IsNullOrEmpty(txtEstado.Text) ||
                    string.IsNullOrEmpty(txtObserva.Text)
                    )
                {
                    MessageBox.Show("Por favor complete todos los campos obligatorios",
                                   "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Planta nuevaPlanta = new Planta
                {
                    
                    id_lote = Convert.ToInt32(txtLote.Text),
                    fecha_plantacion = Convert.ToDateTime(txtFecha.Text),
                    estado = txtEstado.Text,
                    observaciones = txtObserva.Text
                };

                
                plantas.Add(nuevaPlanta);
                dataviewDatos.Rows.Add(txtLote.Text,
                                        txtPlanta_name.Text,
                                        txtFecha.Text,
                                        txtEstado.Text,
                                        txtObserva.Text
                );  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Los Datos no pudieron ser almacenados " + ex.Message);
            }
        }
    }
}
