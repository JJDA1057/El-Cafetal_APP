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
    public partial class Plantas : Form
    {
        public Plantas()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<clsPlanta> resultadoCompleto = new List<clsPlanta>();

                plantaServices plant = new plantaServices();
                ConfigurarDataGridView();

                // Esperar a que termine la operación async
                resultadoCompleto = await plant.ConsultarTodasAsync();

                if (resultadoCompleto?.Count > 0)
                {
                    dataGridView1.DataSource = resultadoCompleto;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("No se encontraron plantas en la base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las plantas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            colID.Name = "ID-Planta";
            colID.DataPropertyName = "id_planta";
            colID.HeaderText = "ID-Planta";
            dataGridView1.Columns.Add(colID);

            DataGridViewTextBoxColumn colIdLote = new DataGridViewTextBoxColumn();
            colIdLote.Name = "ID-LOTE";
            colIdLote.DataPropertyName = "id_lote"; // Debe coincidir con la propiedad exacta
            colIdLote.HeaderText = "ID-Lote";
            dataGridView1.Columns.Add(colIdLote);

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado";
            colEstado.DataPropertyName = "estado";
            colEstado.HeaderText = "Estado";
            dataGridView1.Columns.Add(colEstado);

            // Mostrar solo el ID del proveedor
            DataGridViewTextBoxColumn colObservacion = new DataGridViewTextBoxColumn();
            colObservacion.Name = "Observacion";
            colObservacion.DataPropertyName = "observaciones"; // ID directamente
            colObservacion.HeaderText = "Observacion";
            dataGridView1.Columns.Add(colObservacion);

            DataGridViewTextBoxColumn colEntrega = new DataGridViewTextBoxColumn();
            colEntrega.Name = "Fecha-Plantacion";
            colEntrega.DataPropertyName = "fecha_plantacion";
            colEntrega.HeaderText = "Fecha-Plantacion";
            dataGridView1.Columns.Add(colEntrega);
        }



        // Configurar propiedades básicas del DataGridView



        private void button2_Click(object sender, EventArgs e)
        {

            this.Close(); // Cierra Plantas
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (AgregarPlanta plant = new AgregarPlanta())
                {
                    this.Hide(); // Oculta Inventario
                    plant.ShowDialog(); // Muestra Semillas como modal
                    this.Show(); // Al cerrar Semillas, vuelve a mostrar Inventario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Pedir ID del insumo a borrar
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el ID del planta a eliminar:",
                    "Eliminar Planta: ",
                    "");

                // 2. Validar que se ingresó un valor
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Debe ingresar un ID válido", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Validar que sea un número
                if (!int.TryParse(input, out int idPlanta))
                {
                    MessageBox.Show("El ID debe ser un número válido", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Crear instancia del servicio
                var Service = new plantaServices();

                // 5. Obtener datos del insumo para confirmación
                var resultadoConsulta = await Service.ConsultarPorIdAsync(idPlanta);

                // Verificar si se obtuvieron datos
                if (resultadoConsulta == null)
                {
                    MessageBox.Show($"No se encontró ningún insumo con ID {idPlanta}",
                                  "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtener datos del objeto
                int id = resultadoConsulta.id_planta;
                int idL = resultadoConsulta.id_lote;
                string estado = resultadoConsulta.estado ?? "Desconocido";


                // 6. Mostrar datos y pedir confirmación
                string mensajeConfirmacion = $"¿Está seguro que desea eliminar este insumo?\n\n" +
                                           $"ID: {id}\n" +
                                           $"ESTADO: {estado}\n" +
                                           $"ID_Lote: {idL}";

                DialogResult confirmacion = MessageBox.Show(
                    mensajeConfirmacion,
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (confirmacion == DialogResult.Yes)
                {
                    // 7. Proceder con la eliminación
                    bool eliminado = await Service.BorrarInsumoAsync(idPlanta);

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
