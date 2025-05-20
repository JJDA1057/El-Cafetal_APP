using El_Cafetal_APP.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Servicios
{
    public class plantaServices
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly string _baseUrl = "https://localhost:44302/api/Plantas"; // Ajusta la URL según tu API

        // Consultar todas las plantas
        public async Task<List<clsPlanta>> ConsultarTodasAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<clsPlanta>>($"{_baseUrl}/ConsultarTodos");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar plantas: {ex.Message}");
                return new List<clsPlanta>();
            }
        }

        // Consultar plantas por lote
        public async Task<List<clsPlanta>> ConsultarPorLoteAsync(int idLote)
        {
            try
            {
                return await _http.GetFromJsonAsync<List<clsPlanta>>($"{_baseUrl}/ConsultarPorLote/{idLote}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar plantas por lote: {ex.Message}");
                return new List<clsPlanta>();
            }
        }

        // Consultar planta por ID
        public async Task<clsPlanta> ConsultarPorIdAsync(int idplant)
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/Consultar/{idplant}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<clsPlanta>();
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar insumo: {ex.Message}");
                return null;
            }
        }

        // Registrar nueva planta
        public async Task<string> RegistrarPlantaAsync(int idPlanta, int idLote, string estado, string observaciones, DateTime fechaPlantacion)
        {
            try
            {
                var planta = new
                {
                    id_planta = idPlanta,
                    id_lote = idLote,
                    estado = estado,
                    observaciones = observaciones,
                    fecha_plantacion = fechaPlantacion
                };

                var response = await _http.PostAsJsonAsync($"{_baseUrl}/Registrar", planta);
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar planta: {ex.Message}");
                return $"Error al registrar planta: {ex.Message}";
            }
        }

        public async Task<bool> BorrarInsumoAsync(int idPlanta)
        {
            try
            {
                var response = await _http.DeleteAsync($"{_baseUrl}/Borrar/{idPlanta}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar planta: {ex.Message}");
                return false;


            }
        }

        // Modificar estado de planta
        public async Task<string> ModificarEstadoAsync(int idPlanta, string estado)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"{_baseUrl}/ModificarEstado/{idPlanta}", estado);
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar estado: {ex.Message}");
                return $"Error al modificar estado: {ex.Message}";
            }
        }

        // Modificar observaciones de planta
        public async Task<string> ModificarObservacionesAsync(int idPlanta, string observaciones)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"{_baseUrl}/ModificarObservaciones/{idPlanta}", observaciones);
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar observaciones: {ex.Message}");
                return $"Error al modificar observaciones: {ex.Message}";
            }
        }
    }
}
