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

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close(); // Cierra Semillas
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

       
    }
}
