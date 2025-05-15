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
    public partial class EditarNutriente : Form
    {
        private int _idNutriente;
        public EditarNutriente(int idNutriente)
        {
            InitializeComponent();
            _idNutriente = idNutriente;
            CargarDatosNutriente();
        }

        private async void CargarDatosNutriente()
        {
            try
            {
                InsumoServices insumoService = new InsumoServices();
                var insumo = await insumoService.ConsultarPorIdAsync(_idNutriente);

                string[] terminosNutrientes = new string[]
                {
                    "nutriente",
                    "abono",
                    "vitamina",
                    "fertilizante",
                    "mineral",  
                    "compuesto",
                    "bioestimulante", 
                    "enmienda"       
                };

                // Verificar si el tipo contiene alguno de los términos
                bool esNutriente = false;
                if (insumo != null && insumo.tipo != null)
                {
                    string tipoLower = insumo.tipo.ToLower();
                    foreach (string termino in terminosNutrientes)
                    {
                        if (tipoLower.Contains(termino))
                        {
                            esNutriente = true;
                            break;
                        }
                    }
                }

                if (esNutriente)
                {
                    Cid_insumo.Text = _idNutriente.ToString();
                    Cnombre.Text = insumo.nombre;
                    Ctipo.Text = insumo.tipo;
                    Cid_proveedor.Text = insumo.id_proveedor.ToString();
                    Ccantidad.Text = insumo.cantidad.ToString();
                    dateTimePicker2.Value = insumo.f_entrega;

                    // ... otros campos
                }
                else
                {
                    MessageBox.Show("El insumo no es un nutriente o no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // 1. Validar datos (opcional, pero recomendado)
                if (string.IsNullOrEmpty(Cnombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Crear o recuperar el objeto insumo a actualizar
                InsumoServices insumoService = new InsumoServices();
                var insumo = await insumoService.ConsultarPorIdAsync(_idNutriente); // _idNutriente es el ID del formulario

                if (insumo == null)
                {
                    MessageBox.Show("No se encontró el insumo a editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Actualizar el objeto insumo con los datos del formulario
                insumo.nombre = Cnombre.Text;
                insumo.tipo = Ctipo.Text;

                // Validar y convertir id_proveedor (si es necesario)
                if (int.TryParse(Cid_proveedor.Text, out int idProveedor))
                {
                    insumo.id_proveedor = idProveedor;
                }
                else
                {
                    MessageBox.Show("ID de proveedor inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar y convertir cantidad
                if (decimal.TryParse(Ccantidad.Text, out decimal cantidad))
                {
                    insumo.cantidad = Convert.ToInt32(cantidad);
                }
                else
                {
                    MessageBox.Show("Cantidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar la fecha del DateTimePicker (ya es DateTime)
                insumo.f_entrega = dateTimePicker2.Value;

                // 4. Llamar al servicio para guardar los cambios
                bool resultado = await insumoService.ActualizarInsumoAsync(insumo);

                if (resultado)
                {
                    MessageBox.Show("¡Datos actualizados correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Cerrar el formulario de edición
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el insumo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
