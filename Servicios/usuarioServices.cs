using El_Cafetal_APP.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;



namespace El_Cafetal_APP.Servicios
{
    public class usuarioServices
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly string baseUrl = "https://localhost:44302/api/Usuario";

        public async Task<bool> RegistrarUsuarioAsync(clsUsuario usuario)
        {
            try
            {

                var response = await _http.PostAsJsonAsync($"{baseUrl}/Insertar", usuario);



                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
             
                Console.WriteLine("Error al registrar usuario: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> ConsultarCorreoAsync(string correo)
        {
            try
            {
                var response = await _http.GetAsync($"{baseUrl}/ConsultarCorreo?correo={correo}");

                if (response.IsSuccessStatusCode)
                {
                    var existe = await response.Content.ReadAsAsync<bool>();
                    return existe;
                }
                else
                {
                    Console.WriteLine($"Error consultando correo: {response.StatusCode}");
                    return false; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar correo: " + ex.Message);
                return false;
            }
        }


        public async Task<bool> ValidarLoginAsync(string correo, string clave) 
        {
            try
            {
                var response = await _http.GetAsync($"{baseUrl}/ValidarLogin?correo={correo}&clave={clave}");

                if (response.IsSuccessStatusCode)
                {
                    var existe = await response.Content.ReadAsAsync<bool>();
                    return existe;
                }
                else
                {
                    Console.WriteLine($"Error consultando el correo o la clave: {response.StatusCode}");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar el correo o la clave " + ex.Message);
                return false;
            }
        }


        public async Task<bool> EstadoUsuarioAsync(string correo) 
        {
            try
            {
                var response = await _http.GetAsync($"{baseUrl}/EstadoUsuario?correo={correo}");

                if (response.IsSuccessStatusCode)
                {
                    var activo = await response.Content.ReadAsAsync<bool>();
                    return activo;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return false;
                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error al consultar estado de usuario: " + ex.Message);
                return false;
            }
        }

        public async Task<clsUsuario> ConsultarUsuarioPorIdAsync(int id)
        {
            try
            {
                var response = await _http.GetAsync($"{baseUrl}/Consultar?id={id}");

                if (response.IsSuccessStatusCode)
                {
                    var usuario = await response.Content.ReadAsAsync<clsUsuario>();
                    return usuario;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar usuario por ID: " + ex.Message);
                return null;
            }
        }

        public async Task<bool> ActualizarUsuarioAsync(clsUsuario usuario)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"{baseUrl}/Actualizar", usuario);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el usuario: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> EliminarUsuarioAsync(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"{baseUrl}/Eliminar?id={id}");

                    if (response.IsSuccessStatusCode)
                    {
                        string resultado = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Respuesta del servidor: {resultado}");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Error al eliminar usuario. Código: {response.StatusCode}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en EliminarUsuarioAsync: " + ex.Message);
                return false;
            }
        }

        public async Task<List<clsUsuario>> ConsultarTodosUsuariosAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{baseUrl}/ConsultarTodos");

                    if (response.IsSuccessStatusCode)
                    {
                        var listaUsuarios = await response.Content.ReadAsAsync<List<clsUsuario>>();
                        return listaUsuarios;
                    }
                    else
                    {
                        Console.WriteLine("Error al consultar usuarios. Código: " + response.StatusCode);
                        return new List<clsUsuario>();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ConsultarTodosUsuariosAsync: " + ex.Message);
                return new List<clsUsuario>();
            }
        }

        public async Task<int> ConsultarRolPorCorreoAsync(string correo)
        {
            try
            {
                var response = await _http.GetAsync($"{baseUrl}/ConsultarRol?correo={correo}");

                if (response.IsSuccessStatusCode)
                {
                    int idRol = await response.Content.ReadAsAsync<int>();
                    return idRol;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return -1; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar rol: " + ex.Message);
                return -1;
            }
        }



    }
}








