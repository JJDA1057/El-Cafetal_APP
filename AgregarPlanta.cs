using El_Cafetal_APP.Clases;
using El_Cafetal_APP.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Cafetal_APP
{
    public partial class AgregarPlanta : Form
    {
        public AgregarPlanta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                plantaServices plant = new plantaServices();
                // 1. Validación mínima de campos requeridos
                if (string.IsNullOrWhiteSpace(Cid_planta.Text) ||
                    string.IsNullOrWhiteSpace(Cid_lote.Text) ||
                    string.IsNullOrWhiteSpace(Cestado.Text) ||
                    string.IsNullOrWhiteSpace(Cobservacion.Text)


                    )
                {
                    MessageBox.Show("Debe completar los campos obligatorios", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Convertir datos (con validación básica)
                if (!int.TryParse(Cid_planta.Text, out int idplanta))
                {
                    MessageBox.Show("El ID de planta debe ser un número", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Crear objeto con los datos del formulario
                var nuevaPlanta = new clsPlanta
                {
                    id_planta = int.Parse(Cid_planta.Text),
                    id_lote = int.Parse(Cid_lote.Text),
                    estado = Cestado.Text,
                    observaciones = Cobservacion.Text ?? "", // Asigna cadena vacía si es null
                    fecha_plantacion = dateTimePicker1.Checked ? dateTimePicker1.Value : DateTime.Now
                };

                // 4. Llamar al servicio
                string resultado = await new plantaServices().RegistrarPlantaAsync(
                    nuevaPlanta.id_planta,
                    nuevaPlanta.id_lote,
                    nuevaPlanta.estado,
                    nuevaPlanta.observaciones,
                    nuevaPlanta.fecha_plantacion);

                // 5. Mostrar resultado y cerrar
                MessageBox.Show(resultado, "Resultado");
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
