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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Cafetal_APP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string correo = txtCorreo.Text.Trim();
                string clave = txtClave.Text.Trim();
                usuarioServices usuario = new usuarioServices();

                
                bool habilitado = await usuario.EstadoUsuarioAsync(correo);

                if (habilitado)
                {
                    if (string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(correo))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.");
                        return;
                    }



                    bool confirmado = await usuario.ValidarLoginAsync(correo, clave);

                    if (confirmado)
                    {
                        int idRol = await usuario.ConsultarRolPorCorreoAsync(correo);

                        if (idRol == 1)
                        {
                            Admin admin = new Admin();
                            admin.Show();
                        }
                        else
                        {
                            AgregarCultivo agregar = new AgregarCultivo();
                            agregar.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Correo o clave incorrecto.");
                        return;
                    }


                }
                else 
                {
                    MessageBox.Show("Usuario deshabilitado.Comuniquese con el admin.");
                    txtClave.Text = "";
                    txtCorreo.Text = "";
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
