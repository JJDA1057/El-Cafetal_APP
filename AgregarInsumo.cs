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
    public partial class AgregarInsumo : Form
    {
        public AgregarInsumo()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InsumoServices insumo = new InsumoServices();
                // 1. Validación mínima de campos requeridos
                if (string.IsNullOrWhiteSpace(Cid.Text) ||
                    string.IsNullOrWhiteSpace(Cnombre.Text) ||
                    string.IsNullOrWhiteSpace(Ctipo.Text) ||
                    string.IsNullOrWhiteSpace(Cprov.Text) ||
                    string.IsNullOrWhiteSpace(Ccantidad.Text)


                    )
                {
                    MessageBox.Show("Debe completar los campos obligatorios", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Convertir datos (con validación básica)
                if (!int.TryParse(Cid.Text, out int idInsumo))
                {
                    MessageBox.Show("El ID de Insumo debe ser un número", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Crear objeto con los datos del formulario
                var nuevo = new clsInsumo
                {
                    id_insumo = int.Parse(Cid.Text),
                    nombre = Cnombre.Text,
                    tipo = Ctipo.Text,
                    id_proveedor = int.Parse(Cprov.Text),
                    cantidad = int.Parse(Ccantidad.Text),
                    f_entrega = dateTimePicker1.Checked ? dateTimePicker1.Value : DateTime.Now
                };

                // 4. Llamar al servicio
                string resultado = await new InsumoServices().RegistrarInsumoAsync(
                    nuevo.id_insumo,
                    nuevo.nombre,
                    nuevo.tipo,
                    nuevo.id_proveedor,
                    nuevo.cantidad,
                    nuevo.f_entrega);

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
