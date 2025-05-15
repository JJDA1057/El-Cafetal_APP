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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_Cafetal_APP
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {

            try
            {

                int id = int.Parse(txtId.Text);
                usuarioServices servicio = new usuarioServices();

                var usuario = await servicio.ConsultarUsuarioPorIdAsync(id);

                if (usuario != null)
                {
                    txtNombre.Text = usuario.nombre;
                    txtCorreo.Text = usuario.correo;
                    txtClave.Text = usuario.contraseña;
                    txtRol.Text = usuario.id_rol.ToString();
                    txtEstado.Text = usuario.estado_usuario ? "Activo" : "Inactivo";
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Debe ingresar un id valido para consulta."+ex);
            }

        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                bool estadoUsuario;
                if (txtEstado.Text.Trim().ToLower() == "activo")
                {
                    estadoUsuario = true;
                }
                else if (txtEstado.Text.Trim().ToLower() == "inactivo")
                {
                    estadoUsuario = false;
                }
                else
                {
                    MessageBox.Show("El estado debe ser 'Activo' o 'Inactivo'.");
                    return;
                }

                clsUsuario usuario = new clsUsuario
                {
                    id_usuario = int.Parse(txtId.Text.Trim()),
                    nombre = txtNombre.Text.Trim(),
                    correo = txtCorreo.Text.Trim(),
                    contraseña = txtClave.Text.Trim(),
                    id_rol = int.Parse(txtRol.Text.Trim()),
                    estado_usuario = estadoUsuario
                };


                var usuarioService = new usuarioServices();


                bool resultado = await usuarioService.ActualizarUsuarioAsync(usuario);

                if (resultado)
                {
                    MessageBox.Show("Usuario actualizado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtRol.Text = "";
            txtEstado.Text = "";
        }

        private async void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtId.Text) ||
               string.IsNullOrWhiteSpace(txtClave.Text) ||
               string.IsNullOrWhiteSpace(txtRol.Text) ||
               string.IsNullOrWhiteSpace(txtEstado.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                bool estadoUsuario;
                string estadoTexto = txtEstado.Text.Trim().ToLower();
                if (estadoTexto == "activo")
                    estadoUsuario = true;
                else if (estadoTexto == "inactivo")
                    estadoUsuario = false;
                else
                {
                    MessageBox.Show("El estado debe ser 'Activo' o 'Inactivo'.");
                    return;
                }


                usuarioServices usuario = new usuarioServices();
                bool correoExiste = await usuario.ConsultarCorreoAsync(txtCorreo.Text);

                if (correoExiste == true)
                {
                    MessageBox.Show("Este correo ya está registrado. Usa otro correo.");
                    return;
                }

                var nuevoUsuario = new clsUsuario
                {
                    id_usuario = int.Parse(txtId.Text),
                    nombre = txtNombre.Text.Trim(),
                    correo = txtCorreo.Text.Trim(),
                    contraseña = txtClave.Text.Trim(),
                    id_rol = int.Parse(txtRol.Text.Trim()),
                    estado_usuario = estadoUsuario,
                    estado_verificacion = false,
                    codigo_verificacion = null

                };

               
                bool registrado = await usuario.RegistrarUsuarioAsync(nuevoUsuario);

                if (registrado)
                {
                    MessageBox.Show("Usuario registrado con éxito.");

                }
                else
                {
                    MessageBox.Show("Error al registrar usuario.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var servicio = new usuarioServices();

             
                var usuario = await servicio.ConsultarUsuarioPorIdAsync(id);

                if (usuario != null)
                {
                   
                    if (usuario.id_rol == 1)
                    {
                        MessageBox.Show("No se puede eliminar un usuario con rol de administrador.");
                        return; 
                    }

                    
                    bool eliminado = await servicio.EliminarUsuarioAsync(id);

                    if (eliminado)
                        MessageBox.Show("Usuario eliminado con éxito.");
                    else
                        MessageBox.Show("No se pudo eliminar el usuario.");
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar los datos para poder borrar."+ex);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private async void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            ConsultarTodos ventana = new ConsultarTodos();
            await ventana.CargarUsuarios(); 
            ventana.Show();
            this.Hide();
        }
    }
}
