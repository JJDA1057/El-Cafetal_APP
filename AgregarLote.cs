
using El_Cafetal_APP.Clases;
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
    public partial class AgregarLote : Form
    {
        public AgregarLote()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtIDuser.Text)
                    || string.IsNullOrEmpty(txtEstado.Text) || string.IsNullOrEmpty(txtArea.Text)
                    || string.IsNullOrEmpty(txtCant_plant.Text) || string.IsNullOrEmpty(txtObserv.Text)|| string.IsNullOrEmpty(txtId_Cultivo.Text))
                {
                    MessageBox.Show("Por favor ingrese todos los campos.");
                    return;
                }


                int id = int.Parse(txtId.Text.Trim());
                int id_usuario = int.Parse(txtIDuser.Text.Trim());
                string estado = txtEstado.Text.Trim();
                double area = double.Parse(txtArea.Text.Trim());
                int cant_plant = int.Parse(txtCant_plant.Text.Trim());
                string observaciones = txtObserv.Text.Trim();
                string id_cultivo = txtId_Cultivo.Text.Trim();

                clsLote nuevoLote = new clsLote
                {
                    id_lote = id,
                    id_usuario = id_usuario,
                    estado = estado,
                    inicio_siembra= DateTime.Now,
                    fecha_fin_siembra = DateTime.Now.AddMonths(12),
                    ubicacion= txtArea.Text.Trim(),
                    cantidad_plantas = cant_plant,
                    observaciones = observaciones,
                    id_cultivo = int.Parse(id_cultivo)
                };

                LoteServices lot= new LoteServices();
                bool registro = lot.Equals(nuevoLote);
                
                if (registro)
                {
                    MessageBox.Show("Su lote fue diligenciado con exito.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el lote. Por favor, intente nuevamente.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Se presento un percance y no se pudo registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
