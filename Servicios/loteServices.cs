using El_Cafetal_APP.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Servicios
{
    public class LoteServices
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly string _baseUrl = "https://localhost:44302/api/Lotes";

        // Registrar nuevo lote
        public async Task<bool> RegistrarLoteAsync(clsLote nuevoLote)
        {
            try
            {
                var response = await _http.PostAsJsonAsync($"{_baseUrl}/Registrar", nuevoLote);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar lote: {ex.Message}");
                return false;
            }
        }

        // Actualizar lote existente
        public async Task<bool> ActualizarLoteAsync(clsLote loteActualizado)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"{_baseUrl}/actualizar/{loteActualizado.id_lote}", loteActualizado);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar lote: {ex.Message}");
                return false;
            }
        }

        // Obtener todos los lotes
        public async Task<List<clsLote>> ConsultarTodosAsync()
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/Consultar");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<clsLote>>();
                }
                return new List<clsLote>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar lotes: {ex.Message}");
                return new List<clsLote>();
            }
        }

        // Obtener lote por ID
        public async Task<clsLote> ConsultarPorIdAsync(int idLote)
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/Consultar/{idLote}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<clsLote>();
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar lote: {ex.Message}");
                return null;
            }
        }

        // Obtener lotes por estado
        public async Task<List<clsLote>> ConsultarPorEstadoAsync(string estado)
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/estado/{estado}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<clsLote>>();
                }
                return new List<clsLote>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar lotes por estado: {ex.Message}");
                return new List<clsLote>();
            }
        }

        // Obtener lotes por cultivo
        public async Task<List<clsLote>> ConsultarPorCultivoAsync(int idCultivo)
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/cultivo/{idCultivo}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<clsLote>>();
                }
                return new List<clsLote>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar lotes por cultivo: {ex.Message}");
                return new List<clsLote>();
            }
        }

        // Cambiar estado de lote
        public async Task<bool> CambiarEstadoAsync(int idLote, CambioEstadoModel cambioEstado)
        {
            try
            {
                var response = await _http.PatchAsJsonAsync($"{_baseUrl}/cambiar-estado/{idLote}", cambioEstado);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cambiar estado de lote: {ex.Message}");
                return false;
            }
        }

        // Obtener resumen por variedad
        public async Task<dynamic> ObtenerResumenVariedadesAsync()
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/resumen");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<dynamic>();
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener resumen: {ex.Message}");
                return null;
            }
        }

        // Obtener lotes próximos a cosecha
        public async Task<List<clsLote>> ObtenerProximosACosechaAsync()
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/proxima-cosecha");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<clsLote>>();
                }
                return new List<clsLote>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar próximos a cosecha: {ex.Message}");
                return new List<clsLote>();
            }
        }

        // Obtener reporte de productividad
        public async Task<dynamic> ObtenerProductividadAsync()
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/productividad");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<dynamic>();
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener productividad: {ex.Message}");
                return null;
            }
        }
    }

    // Modelo para cambio de estado (debe coincidir con el del controlador)
    public class CambioEstadoModel
    {
        public string NuevoEstado { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
