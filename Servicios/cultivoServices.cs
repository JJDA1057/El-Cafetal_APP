using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using El_Cafetal_APP.Clases;

namespace El_Cafetal_APP.Servicios
{
    public class cultivoServices
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly string baseUrl = "https://localhost:44302/api/Cultivos";


        public async Task<bool> AgregarCultivo(clsCultivo cultivo)
        {
            try
            {
                var response = await _http.PostAsJsonAsync($"{baseUrl}/Insertar", cultivo);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar el cultivo : " + ex.Message);
                return false;
            }
        }


<<<<<<< HEAD
=======
        
>>>>>>> origin
    }
    
}
