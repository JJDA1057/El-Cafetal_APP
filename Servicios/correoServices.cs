using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace El_Cafetal_APP.Servicios
{
    public class correoServices
    {

        private readonly HttpClient _http = new HttpClient();
        private readonly string baseUrl = "https://localhost:44302/api/Correo";

        public async Task<bool> EnviarCorreoVerificacionAsync(string correo)
        {
            try
            {
                var response = await _http.PostAsJsonAsync($"{baseUrl}/EnviarCorreo", correo);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo de verificación: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> VerificarCorreoAsync(string correo, string codigoVerificacion)
        {
            try
            {
                var response = await _http.PostAsJsonAsync($"{baseUrl}/VerificarCorreo?correo={correo}&codigoVerificacion={codigoVerificacion}", new { });

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Error al verificar correo: " + await response.Content.ReadAsStringAsync());
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar correo: " + ex.Message);
                return false;
            }


        }


     
    }
}
