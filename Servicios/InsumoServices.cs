using El_Cafetal_APP.Clases;
using El_Cafetal_APP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Servicios
{
    public class InsumoServices
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly string _baseUrl = "https://localhost:44302/api/Insumo";

        // Registrar nuevo insumo
        public async Task<string> RegistrarInsumoAsync(int id, string nombreI, string tipoI, int id_prov, int cant, DateTime fecha)
        {
            try
            {
                var insu = new
                {
                    id_insumo = id,
                    nombre = nombreI,
                    tipo = tipoI,
                    id_proveedor = id_prov,
                    cantidad = cant,
                    f_entrega = fecha
                };

                var response = await _http.PostAsJsonAsync($"{_baseUrl}/Registrar", insu);

                if (!response.IsSuccessStatusCode)
                {
                    return $"Error: {response.StatusCode}";
                }

                return await response.Content.ReadAsStringAsync(); // Devuelve el mensaje del API
            }
            catch (Exception ex)
            {
                return $"Error al registrar insumo: {ex.Message}";
            }
        }

        // Actualizar insumo existente
        public async Task<bool> ActualizarInsumoAsync(clsInsumo insumoActualizado)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"{_baseUrl}/Actualizar/{insumoActualizado.id_insumo}", insumoActualizado);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar insumo: {ex.Message}");
                return false;
            }
        }

        // Obtener todos los insumos
        public async Task<List<clsInsumo>> ConsultarTodosAsync()
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/ConsultarTodos");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<clsInsumo>>();
                }
                return new List<clsInsumo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar insumos: {ex.Message}");
                return new List<clsInsumo>();
            }
        }

        // Obtener insumo por ID
        public async Task<clsInsumo> ConsultarPorIdAsync(int idInsumo)
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/Consultar/{idInsumo}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<clsInsumo>();
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar insumo: {ex.Message}");
                return null;
            }
        }

        // Obtener insumos por tipo
        public async Task<List<clsInsumo>> ConsultarPorTipoAsync(string tipo)
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/tipo/{tipo}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<clsInsumo>>();
                }
                return new List<clsInsumo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar insumos por tipo: {ex.Message}");
                return new List<clsInsumo>();
            }
        }

        // Obtener insumos por proveedor
        public async Task<List<clsInsumo>> ConsultarPorProveedorAsync(int idProveedor)
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/ConsultarProveedor/{idProveedor}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<clsInsumo>>();
                }
                return new List<clsInsumo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar insumos por proveedor: {ex.Message}");
                return new List<clsInsumo>();
            }
        }

        // Eliminar insumo
        public async Task<bool> EliminarInsumoAsync(int idInsumo)
        {
            try
            {
                var response = await _http.DeleteAsync($"{_baseUrl}/Eliminar/{idInsumo}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar insumo: {ex.Message}");
                return false;


            }

        }

        // Actualizar cantidad de insumo
        public async Task<bool> ActualizarCantidadAsync(int idInsumo, ActualizacionCantidadModel model)
        {
            try
            {
                var response = await _http.PatchAsJsonAsync($"{_baseUrl}/{idInsumo}/cantidad", model);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar cantidad: {ex.Message}");
                return false;
            }
        }



        public async Task<List<clsInsumo>> ConsultarNivelesBajosAsync()
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/nivelesBajos");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<clsInsumo>>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar niveles bajos: {ex.Message}");
            }

            return new List<clsInsumo>();
        }

        public async Task<List<clsInsumo>> ConsultarNivelesCriticosAsync()
        {
            try
            {


                var response = await _http.GetAsync($"{_baseUrl}/nivelesCriticos");
                //var contenido = await response.Content.ReadAsStringAsync();
                
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<clsInsumo>>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar niveles críticos: {ex.Message}");
            }

            return new List<clsInsumo>();
        }

        public async Task<TipoAlerta> VerificarNivelPorIdAsync(int id)
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/verificar-nivel/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<TipoAlerta>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar nivel: {ex.Message}");
            }

            return TipoAlerta.Normal;
        }

    }

    // Modelo para actualización de cantidad (debe coincidir con el del controlador)
        public class ActualizacionCantidadModel
        {
            public int Cantidad { get; set; }
            public bool EsSuma { get; set; }
        }

    
}

