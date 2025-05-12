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
    public partial class ConsultarTodos : Form
    {
        public ConsultarTodos()
        {
            InitializeComponent();
        }

        private async void ConsultarTodos_Load(object sender, EventArgs e)
        {
            await CargarUsuarios();
        }

        public async Task CargarUsuarios()
        {
            usuarioServices servicio = new usuarioServices();
            List<clsUsuario> usuarios = await servicio.ConsultarTodosUsuariosAsync();

            dataGridViewUsuarios.DataSource = usuarios;


            dataGridViewUsuarios.Columns["contraseña"].Visible = false;
            dataGridViewUsuarios.Columns["codigo_verificacion"].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
