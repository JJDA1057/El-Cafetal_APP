using El_Cafetal_APP.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Servicios
{
    public class AdmInsumosServices
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly string _baseUrl = "https://localhost:44302/api/adminsumos";

        // Registrar nueva aplicación de insumo
        public async Task<string> RegistrarAplicacionAsync(clsAdm_insumo nuevaAplicacion)
        {
            try
            {
                var response = await _http.PostAsJsonAsync($"{_baseUrl}/Insertar", nuevaAplicacion);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    return $"Error: {response.StatusCode} - {errorContent}";
                }
            }
            catch (Exception ex)
            {
                return $"Excepción al registrar aplicación: {ex.Message}";
            }
        }

        // Consultar todas las aplicaciones
        public async Task<List<clsAdm_insumo>> ConsultarTodasAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<clsAdm_insumo>>($"{_baseUrl}/ConsultarTodo");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar aplicaciones: {ex.Message}");
                return new List<clsAdm_insumo>();
            }
        }

        // Consultar aplicaciones por lote
        public async Task<List<clsAdm_insumo>> ConsultarPorLoteAsync(int idLote)
        {
            try
            {
                return await _http.GetFromJsonAsync<List<clsAdm_insumo>>($"{_baseUrl}/ConsultaloteA/{idLote}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar por lote: {ex.Message}");
                return new List<clsAdm_insumo>();
            }
        }

        // Consultar aplicaciones por insumo
        public async Task<List<clsAdm_insumo>> ConsultarPorInsumoAsync(int idInsumo)
        {
            try
            {
                return await _http.GetFromJsonAsync<List<clsAdm_insumo>>($"{_baseUrl}/ConsultainsumoA/{idInsumo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar por insumo: {ex.Message}");
                return new List<clsAdm_insumo>();
            }
        }

        // Consultar aplicaciones por rango de fechas
        public async Task<List<clsAdm_insumo>> ConsultarPorFechaAsync(DateTime desde, DateTime hasta)
        {
            try
            {
                return await _http.GetFromJsonAsync<List<clsAdm_insumo>>(
                    $"{_baseUrl}/ConsultafechaA?desde={desde:yyyy-MM-dd}&hasta={hasta:yyyy-MM-dd}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar por fecha: {ex.Message}");
                return new List<clsAdm_insumo>();
            }
        }

      

        // Obtener reporte de insumos más usados
        public async Task<DataTable> ObtenerInsumosMasUsadosAsync()
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/reportes/masusados");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<DataTable>(json);
                }
                return new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener reporte: {ex.Message}");
                return new DataTable();
            }
        }

        // Obtener reporte de consumo mensual
        public async Task<DataTable> ObtenerConsumoMensualAsync()
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/reportes/consumomensual");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<DataTable>(json);
                }
                return new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener consumo mensual: {ex.Message}");
                return new DataTable();
            }
        }

        //GEt nutrientes por lote

        public async Task<DataTable> ObtenerFertilizantesxLoteAsync(int idLote)
        {

            try
            {
                var respuesta = await _http.GetAsync($"{_baseUrl}/porLote/{idLote}");

                if (respuesta.IsSuccessStatusCode)
                {
                    var json = await respuesta.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<DataTable>(json);
                }
                return new DataTable();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener nutrientes por lote: {ex.Message}");
                return new DataTable();
            }


        }

    }
}
