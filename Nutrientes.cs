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
    public partial class Nutrientes : Form
    {
        public Nutrientes()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarInsumosTipoNutrienteAsync();
        }

        private async Task CargarInsumosTipoNutrienteAsync()
        {
            try
            {
                InsumoServices insumoService = new InsumoServices();

                // Lista de términos relacionados con nutrientes
                string[] terminosNutrientes = new string[]
                {
            "nutriente", "nutrientes",
            "abono", "abonos",
            "fertilizante", "fertilizantes",
            "vitamina", "vitaminas",
            "mineral", "minerales",
            "compuesto", "compuestos",
            "bioestimulante", "bioestimulantes",
            "enmienda", "enmiendas"
                };

                // Resultado combinado de todas las búsquedas
                List<clsInsumo> resultadoCompleto = new List<clsInsumo>();

                // Opción 1: Hacer múltiples consultas y combinar resultados
                foreach (string termino in terminosNutrientes)
                {
                    var resultadoParcial = await insumoService.ConsultarPorTipoAsync(termino);
                    if (resultadoParcial != null && resultadoParcial.Count > 0)
                    {
                        // Agregar solo los insumos que no estén ya en la lista (para evitar duplicados)
                        foreach (var insumo in resultadoParcial)
                        {
                            if (!resultadoCompleto.Any(i => i.id_insumo == insumo.id_insumo))
                            {
                                resultadoCompleto.Add(insumo);
                            }
                        }
                    }
                }

                ConfigurarDataGridView(); // Muy importante que vaya antes
                dataGridView1.DataSource = resultadoCompleto;

                if (resultadoCompleto.Count == 0)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra Semillas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
        "Ingrese el ID de el nutriente a editar:",
        "Editar Nutriente: ",
        "");


            // Validar si se ingresó un ID (no vacío y es número)
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int idNutriente))
            {
                // Abrir el formulario de edición y pasarle el ID
                EditarNutriente editarNutriente = new EditarNutriente(idNutriente);
                editarNutriente.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ID inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            AdmInsumosServices admService = new AdmInsumosServices();

            // 1. Pedir al usuario el ID del lote
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el ID del lote:",
                "Nutrientes Por Lote",
                "");

            // 2. Validar que se ingresó un valor
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Debe ingresar un ID de lote válido", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validar que sea un número
            if (!int.TryParse(input, out int idLote))
            {
                MessageBox.Show("El ID del lote debe ser un número válido", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 4. Crear el formulario flotante
                var formFlotante = new Form
                {
                    Text = $"Nutrientes para Lote {idLote}",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.SizableToolWindow,
                    Width = 1000,
                    Height = 600,
                    ShowInTaskbar = false
                };

                // 5. Configurar DataGridView
                var dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    BackgroundColor = SystemColors.Window
                };

                // 6. Panel de carga
                var panelCarga = new Panel { Dock = DockStyle.Fill };
                var lblCarga = new Label
                {
                    Text = "Cargando datos del lote...",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12)
                };
                panelCarga.Controls.Add(lblCarga);
                formFlotante.Controls.Add(panelCarga);
                formFlotante.Show(); // Mostrar antes de cargar datos para mejor experiencia

                // 7. Obtener datos asincrónicamente
                var datos = await admService.ObtenerFertilizantesxLoteAsync(idLote);

                // 8. Configurar datos en la grilla
                formFlotante.Controls.Remove(panelCarga);
                formFlotante.Controls.Add(dgv);

                dgv.DataSource = datos;

                // 9. Mejorar presentación de datos
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.EnableHeadersVisualStyles = false;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

                // 10. Configurar formato de columnas específicas
                if (dgv.Columns.Contains("Cantidad"))
                {
                    dgv.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
                    dgv.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgv.Columns.Contains("Fecha"))
                {
                    dgv.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgv.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                // 11. Ajustar automáticamente el ancho de columnas después de cargar datos
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nutrientes: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void button5_Click(object sender, EventArgs e)
        {

            try
            {
                // 1. Pedir ID del insumo a borrar
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el ID del insumo a eliminar:",
                    "Eliminar Insumo",
                    "");

                // 2. Validar que se ingresó un valor
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Debe ingresar un ID válido", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Validar que sea un número
                if (!int.TryParse(input, out int idInsumo))
                {
                    MessageBox.Show("El ID debe ser un número válido", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Crear instancia del servicio
                var insumoService = new InsumoServices();

                // 5. Obtener datos del insumo para confirmación
                var resultadoConsulta = await insumoService.ConsultarPorIdAsync(idInsumo);

                // Verificar si se obtuvieron datos
                if (resultadoConsulta == null)
                {
                    MessageBox.Show($"No se encontró ningún insumo con ID {idInsumo}",
                                  "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtener datos del objeto
                string nombre = resultadoConsulta.nombre ?? "Desconocido"; 
                string tipo = resultadoConsulta.tipo ?? "No especificado"; 

                // 6. Mostrar datos y pedir confirmación
                string mensajeConfirmacion = $"¿Está seguro que desea eliminar este insumo?\n\n" +
                                           $"ID: {idInsumo}\n" +
                                           $"Nombre: {nombre}\n" +
                                           $"Tipo: {tipo}";

                DialogResult confirmacion = MessageBox.Show(
                    mensajeConfirmacion,
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (confirmacion == DialogResult.Yes)
                {
                    // 7. Proceder con la eliminación
                    bool eliminado = await insumoService.EliminarInsumoAsync(idInsumo);

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
        }
}
