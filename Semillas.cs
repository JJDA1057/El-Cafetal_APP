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
using static System.Net.WebRequestMethods;

namespace El_Cafetal_APP
{
    public partial class Semillas : Form
    {
        public Semillas()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarInsumosTipoSemillaAsync();
        }

        private async Task CargarInsumosTipoSemillaAsync()
        {
            try
            {
                InsumoServices insumoService = new InsumoServices();
                var resultado = await insumoService.ConsultarPorTipoAsync("semilla");

                ConfigurarDataGridView(); // <- Muy importante que vaya antes
                dataGridView1.DataSource = resultado;

                if (resultado.Count == 0)
                {
                    MessageBox.Show("No se encontraron insumos del tipo especificado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los insumos: " + ex.Message);
            }
        }


        private void ConfigurarDataGridView()
        {
            // Limpiar columnas existentes
            dataGridView1.Columns.Clear();

            // Configurar propiedades básicas del DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Crear y agregar columnas
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "ID-Insumo";
            colID.DataPropertyName = "id_insumo";
            colID.HeaderText = "ID-Insumo";
            dataGridView1.Columns.Add(colID);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.DataPropertyName = "nombre"; // Debe coincidir con la propiedad exacta
            colNombre.HeaderText = "Nombre";
            dataGridView1.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.Name = "Cantidad";
            colCantidad.DataPropertyName = "cantidad";
            colCantidad.HeaderText = "Cantidad";
            dataGridView1.Columns.Add(colCantidad);

            // Mostrar solo el ID del proveedor
            DataGridViewTextBoxColumn colProveedor = new DataGridViewTextBoxColumn();
            colProveedor.Name = "Proveedor";
            colProveedor.DataPropertyName = "id_proveedor"; // ID directamente
            colProveedor.HeaderText = "ID Proveedor";
            dataGridView1.Columns.Add(colProveedor);

            DataGridViewTextBoxColumn colEntrega = new DataGridViewTextBoxColumn();
            colEntrega.Name = "Fecha-Entrega";
            colEntrega.DataPropertyName = "f_entrega";
            colEntrega.HeaderText = "Fecha-Entrega";
            dataGridView1.Columns.Add(colEntrega);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Pedir ID del insumo a borrar
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el ID de la semilla a eliminar:",
                    "Eliminar Semilla: ",
                    "");

                // 2. Validar que se ingresó un valor
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Debe ingresar un ID válido", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Validar que sea un número
                if (!int.TryParse(input, out int idSemilla))
                {
                    MessageBox.Show("El ID debe ser un número válido", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Crear instancia del servicio
                var insumoService = new InsumoServices();

                // 5. Obtener datos del insumo para confirmación
                var resultadoConsulta = await insumoService.ConsultarPorIdAsync(idSemilla);

                // Verificar si se obtuvieron datos
                if (resultadoConsulta == null)
                {
                    MessageBox.Show($"No se encontró ninguna semilla con ID {idSemilla}",
                                  "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtener datos del objeto
                string nombre = resultadoConsulta.nombre ?? "Desconocido";
                int cantidad = resultadoConsulta.cantidad;

                // 6. Mostrar datos y pedir confirmación
                string mensajeConfirmacion = $"¿Está seguro que desea eliminar este insumo?\n\n" +
                                           $"ID: {idSemilla}\n" +
                                           $"Nombre: {nombre}\n" +
                                           $"Tipo: {cantidad}";

                DialogResult confirmacion = MessageBox.Show(
                    mensajeConfirmacion,
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (confirmacion == DialogResult.Yes)
                {
                    // 7. Proceder con la eliminación
                    bool eliminado = await insumoService.EliminarInsumoAsync(idSemilla);

                    if (eliminado)
                    {
                        MessageBox.Show("Insumo eliminado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el insumo. Puede que esté en uso o no exista.",
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar el insumo: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
        "Ingrese el ID de la semilla a editar:",
        "Editar Semilla",
        "");


            // Validar si se ingresó un ID (no vacío y es número)
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int idSemilla))
            {
                // Abrir el formulario de edición y pasarle el ID
                EditarSemilla editarSemilla = new EditarSemilla(idSemilla);
                editarSemilla.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ID inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
