using System;
using El_Cafetal_APP.Clases;
using El_Cafetal_APP.Servicios;
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
    public partial class Lote : Form
    {

        public Lote()
        {
            InitializeComponent();
            RegistroDataViewGrid();
            CargarLotes();
        }

        private void BtnVolver_Click(object sender, EventArgs e) // Fixed IDE1006: Method name starts with uppercase
        {
            AgregarLote addLote = new AgregarLote();
            this.Hide();
            addLote.ShowDialog();
            CargarLotes();
            this.Show();
        }

        private void RegistroDataViewGrid()
        {
            dataGridViewLotes.AutoGenerateColumns = false;

            dataGridViewLotes.Columns.Add("id_lote", "ID Lote");
            dataGridViewLotes.Columns.Add("id_usuario", "ID Usuario");
            dataGridViewLotes.Columns.Add("estado", "Estado");
            dataGridViewLotes.Columns.Add("inicio_siembra", "Inicio Siembra");
            dataGridViewLotes.Columns.Add("fecha_fin_siembra", "Fecha Fin Siembra");
            dataGridViewLotes.Columns.Add("ubicacion", "Ubicación");
            dataGridViewLotes.Columns.Add("cantidad_plantas", "Cantidad Plantas");
            dataGridViewLotes.Columns.Add("observaciones", "Observaciones");
            dataGridViewLotes.Columns.Add("id_cultivo", "ID Cultivo");
        }

        private void CargarLotes()
        {
            try
            {
                clsLote loteMetod = new clsLote();
                LoteServices loteService = new LoteServices();
                var lotes = loteService.ConsultarTodosAsync().Result;

                dataGridViewLotes.Rows.Clear();

                foreach (var lote in lotes)
                {
                    dataGridViewLotes.Rows.Add(
                        lote.id_lote,
                        lote.id_usuario,
                        lote.estado,
                        lote.inicio_siembra,
                        lote.fecha_fin_siembra,
                        lote.ubicacion,
                        lote.cantidad_plantas,
                        lote.observaciones,
                        lote.id_cultivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los lotes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e) // Fixed CS1585 and IDE1006: Corrected modifier placement and method name
        {

        }
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            AgregarLote addLote = new AgregarLote();
            this.Hide();
            addLote.ShowDialog();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewLotes.CurrentRow != null)
                {
                    int idLote = Convert.ToInt32(dataGridViewLotes.CurrentRow.Cells["id_lote"].Value);

                    LoteServices loteServicio = new LoteServices();

                    bool borrado = loteServicio.BorrarLoteAsync(idLote).Result;

                    if (borrado)
                    {
                        CargarLotes();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewLotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Selecciona toda la fila cuando el usuario hace clic en cualquier parte.
                dataGridViewLotes.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
            this.Show();
        }
    }
}
