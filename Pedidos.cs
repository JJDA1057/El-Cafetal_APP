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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<clsProveedor> resultadoCompleto = new List<clsProveedor>();

                proveedorServices prov = new proveedorServices();
                ConfigurarDataGridView();

                // Esperar a que termine la operación async
                resultadoCompleto = await prov.ConsultarTodosAsync();

                if (resultadoCompleto?.Count > 0)
                {
                    dataGridView1.DataSource = resultadoCompleto;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("No se encontraron pedidos a proveedores en la base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedroes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            colID.Name = "ID-Proveedor";
            colID.DataPropertyName = "id_proveedor";
            colID.HeaderText = "ID-Proveedor";
            dataGridView1.Columns.Add(colID);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.DataPropertyName = "nombre"; // Debe coincidir con la propiedad exacta
            colNombre.HeaderText = "Nombre";
            dataGridView1.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colCel_fijo = new DataGridViewTextBoxColumn();
            colCel_fijo.Name = "Celular-Telefono";
            colCel_fijo.DataPropertyName = "cel_fijo";
            colCel_fijo.HeaderText = "Celular-Telefono";
            dataGridView1.Columns.Add(colCel_fijo);

            // Mostrar solo el ID del proveedor
            DataGridViewTextBoxColumn colTipoMaterial = new DataGridViewTextBoxColumn();
            colTipoMaterial.Name = "Tipo Material";
            colTipoMaterial.DataPropertyName = "tipo_material"; // ID directamente
            colTipoMaterial.HeaderText = "Tipo Material";
            dataGridView1.Columns.Add(colTipoMaterial);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (AgregarPedido ped = new AgregarPedido())
                {
                    this.Hide(); // Oculta pagina actual
                    ped.ShowDialog(); // Muestra clase como modal
                    this.Show(); // Al cerrar, vuelve a mostrar pagina
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Pedir ID del proveedor a borrar
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el ID del proveedor a eliminar:",
                    "Eliminar proveedor: ",
                    "");

                // 2. Validar que se ingresó un valor
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Debe ingresar un ID válido", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Validar que sea un número
                if (!int.TryParse(input, out int idProv))
                {
                    MessageBox.Show("El ID debe ser un número válido", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Crear instancia del servicio
                var Service = new proveedorServices();

                // 5. Obtener datos para confirmación
                var resultadoConsulta = await Service.ConsultarPorIdAsync(idProv);

                // Verificar si se obtuvieron datos
                if (resultadoConsulta == null)
                {
                    MessageBox.Show($"No se encontró ningún Proveedor con ID {idProv}",
                                  "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtener datos del objeto
                int id = resultadoConsulta.id_proveedor;
                string nombre = resultadoConsulta.nombre;
                string estado = resultadoConsulta.tipo_material;


                // 6. Mostrar datos y pedir confirmación
                string mensajeConfirmacion = $"¿Está seguro que desea eliminar este proveedor?\n\n" +
                                           $"ID: {id}\n" +
                                           $"NOMBRE: {nombre}\n" +
                                           $"TIPO MATERIAL: {estado}";

                DialogResult confirmacion = MessageBox.Show(
                    mensajeConfirmacion,
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (confirmacion == DialogResult.Yes)
                {
                    // 7. Proceder con la eliminación
                    bool eliminado = await Service.EliminarProveedorAsync(idProv);

                    if (eliminado)
                    {
                        MessageBox.Show("Proveedor eliminado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proveedor. Puede que esté en uso o no exista.",
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar el proveedor: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (AgregarInsumo ins = new AgregarInsumo())
                {
                    this.Hide(); // Oculta Inventario
                    ins.ShowDialog(); // Muestra pagina como modal
                    this.Show(); // Al cerrar Semillas, vuelve a mostrar Inventario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
