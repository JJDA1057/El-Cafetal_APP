using El_Cafetal_APP.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Servicios
{
    public class ProveedorServices
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly string _baseUrl = "https://localhost:44302/api/Proveedores";

        // Consultar todos los proveedores
        public async Task<List<clsProveedor>> ConsultarTodosAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<clsProveedor>>($"{_baseUrl}/Consultar");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar proveedores: {ex.Message}");
                return new List<clsProveedor>();
            }
        }

        // Consultar proveedor por ID
        public async Task<clsProveedor> ConsultarPorIdAsync(int idprov)
        {
            try
            {
                var response = await _http.GetAsync($"{_baseUrl}/Consultar/{idprov}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<clsProveedor>();
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar insumo: {ex.Message}");
                return null;
            }
        }

        // Consultar por tipo de material
        public async Task<List<clsProveedor>> ConsultarPorTipoMaterialAsync(string tipoMaterial)
        {
            try
            {
                return await _http.GetFromJsonAsync<List<clsProveedor>>($"{_baseUrl}/Material/{tipoMaterial}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar por tipo de material: {ex.Message}");
                return new List<clsProveedor>();
            }
        }

        // Registrar nuevo proveedor
        public async Task<string> RegistrarProveedorAsync(int id, string nombrep, string cel, string tipo)
        {
            try
            {
                var prov = new
                {
                    id_proveedor = id,
                    nombre = nombrep,
                    cel_fijo = cel,
                    tipo_material = tipo
                };

                var response = await _http.PostAsJsonAsync($"{_baseUrl}/Registrar", prov);
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar planta: {ex.Message}");
                return $"Error al registrar planta: {ex.Message}";
            }
        }

        // Actualizar proveedor
        public async Task<bool> ActualizarProveedorAsync(clsProveedor proveedorActualizado)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"{_baseUrl}/Actualizar/{proveedorActualizado.id_proveedor}", proveedorActualizado);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar proveedor: {ex.Message}");
                return false;
            }
        }

        // Eliminar proveedor
        public async Task<bool> EliminarProveedorAsync(int id)
        {
            try
            {
                var response = await _http.DeleteAsync($"{_baseUrl}/Borrar/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar proveedor: {ex.Message}");
                return false;
            }
        }
    }
}
