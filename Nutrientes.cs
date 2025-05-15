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
    }
}
