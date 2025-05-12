using El_Cafetal_APP.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using El_Cafetal_APP.Servicios;

namespace El_Cafetal_APP
{

    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            var roles = new List<KeyValuePair<int, string>>
        {
            new KeyValuePair<int, string>(2, "Supervisor"),
            new KeyValuePair<int, string>(3, "Agricultor"),
             new KeyValuePair<int, string>(4, "Proveedor")
        };

            comboRol.DataSource = new BindingSource(roles, null);
            comboRol.DisplayMember = "Value";
            comboRol.ValueMember = "Key";



        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(txtId.Text.Trim());
                string nombre = txtNombre.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string clave = txtClave.Text.Trim();
                int idRol = ((KeyValuePair<int, string>)comboRol.SelectedItem).Key;


                if (string.IsNullOrEmpty(txtId.Text.Trim()) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(correo) || comboRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                usuarioServices usuario = new usuarioServices();
                bool correoExiste = await usuario.ConsultarCorreoAsync(correo);

                if (correoExiste == true)
                {
                    MessageBox.Show("Este correo ya está registrado. Usa otro correo.");
                    return;
                }




                clsUsuario nuevoUsuario = new clsUsuario
                {
                    id_usuario = id,
                    nombre = nombre,
                    correo = correo,
                    contraseña = clave,
                    id_rol = idRol,
                    estado_usuario = true
                };



                correoServices correos = new correoServices();
                bool exito = await usuario.RegistrarUsuarioAsync(nuevoUsuario);
                if (exito)
                {

                    MessageBox.Show("Usuario registrado con éxito. Un correo de verificación ha sido enviado.");


                    bool correoEnviado = await correos.EnviarCorreoVerificacionAsync(correo);

                    if (correoEnviado)
                    {

                        string codigoVerificacion = Microsoft.VisualBasic.Interaction.InputBox(
                            "Por favor, ingresa el código de verificación enviado a tu correo.",
                            "Verificación de Correo",
                            "",
                            -1,
                            -1);

                        if (!string.IsNullOrEmpty(codigoVerificacion))
                        {

                            bool codigoValido = await correos.VerificarCorreoAsync(correo, codigoVerificacion);

                            if (codigoValido)
                            {
                                MessageBox.Show("Correo verificado correctamente.");
                                Login login = new Login();
                                login.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Código de verificación incorrecto. Intenta de nuevo.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El código de verificación es requerido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al enviar el correo de verificación.");
                    }
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

        private void linkInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

