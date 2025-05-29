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
    public partial class AgregarPedido : Form
    {
        public AgregarPedido()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                proveedorServices prov = new proveedorServices();
                // 1. Validación mínima de campos requeridos
                if (string.IsNullOrWhiteSpace(Cid.Text) ||
                    string.IsNullOrWhiteSpace(Cnombre.Text) ||
                    string.IsNullOrWhiteSpace(Ccontacto.Text) ||
                    string.IsNullOrWhiteSpace(Cmaterial.Text)


                    )
                {
                    MessageBox.Show("Debe completar los campos obligatorios", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Convertir datos (con validación básica)
                if (!int.TryParse(Cid.Text, out int idprov))
                {
                    MessageBox.Show("El ID de planta debe ser un número", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Crear objeto con los datos del formulario
                var nuevo = new clsProveedor
                {
                    id_proveedor = int.Parse(Cid.Text),
                    nombre = Cnombre.Text,
                    cel_fijo = Ccontacto.Text,
                    tipo_material = Cmaterial.Text, // Asigna cadena vacía si es null
                };

                // 4. Llamar al servicio
                string resultado = await new proveedorServices().RegistrarProveedorAsync(
                    nuevo.id_proveedor,
                    nuevo.nombre,
                    nuevo.cel_fijo,
                    nuevo.tipo_material);

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
