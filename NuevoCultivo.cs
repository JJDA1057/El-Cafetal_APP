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
    public partial class NuevoCultivo : Form
    {
        public NuevoCultivo()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombre.Text)
                    || string.IsNullOrEmpty(txtUbi.Text) || string.IsNullOrEmpty(txtFechaInicio.Text)
                    || string.IsNullOrEmpty(txtFechaFin.Text) || string.IsNullOrEmpty(txtIdUsuario.Text))
                {
                    MessageBox.Show("Por favor ingrese todos los campos.");
                    return;
                }

                int id = int.Parse(txtId.Text.Trim());
                string nombre = txtNombre.Text.Trim();
                string ubicacion = txtUbi.Text.Trim();
                DateTime fecha_inicio = DateTime.Parse(txtFechaInicio.Text.Trim());
                DateTime fecha_fin = DateTime.Parse(txtFechaFin.Text.Trim());
                int id_usuario = int.Parse(txtIdUsuario.Text.Trim());



                clsCultivo nuevoCultivo = new clsCultivo
                {
                    id_cultivo = id,
                    nombre = nombre,
                    ubicacion = ubicacion,
                    fecha_inicio = fecha_inicio,
                    fecha_fin = fecha_fin,
                    id_usuario = id_usuario
                };

                cultivoServices cultivo = new cultivoServices();
                bool exito = await cultivo.AgregarCultivo(nuevoCultivo);

                if (exito)
                {
                    MessageBox.Show("Cultivo registrado con exito.");
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el cultivo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void NuevoCultivo_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
