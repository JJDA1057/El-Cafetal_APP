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
            this.Load += new System.EventHandler(this.Form1_Load);
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

    }
}
