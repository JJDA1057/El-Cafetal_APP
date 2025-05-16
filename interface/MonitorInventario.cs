
using El_Cafetal_APP.Clases;
using El_Cafetal_APP.Enums;
using El_Cafetal_APP.Servicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_CAFETAL.Interface
{
    public class MonitorInventario : IInventarioObservableW
    {
        private List<IInventarioObserver> _observadores = new List<IInventarioObserver>();
        private InsumoServices _servicioInsumo;

        public MonitorInventario(InsumoServices servicioInsumo)
        {
            _servicioInsumo = servicioInsumo;
        }

        public void AgregarObservador(IInventarioObserver observador)
        {
            if (!_observadores.Contains(observador))
                _observadores.Add(observador);
        }

        public void EliminarObservador(IInventarioObserver observador)
        {
            if (_observadores.Contains(observador))
                _observadores.Remove(observador);
        }

        public void NotificarObservadores(clsInsumo insumo, TipoAlerta tipoAlerta)
        {
            if (_observadores == null || _observadores.Count == 0)
                return;

            foreach (var observador in _observadores)
            {
                observador.Actualizar(insumo, tipoAlerta);
            }
        }

        // Verificar todos los insumos y notificar sobre niveles bajos
        public async Task VerificarInventario()
        {
            var insumosNivelesBajos = await  _servicioInsumo.ConsultarNivelesBajosAsync();
            var insumosNivelesCriticos = await  _servicioInsumo.ConsultarNivelesCriticosAsync();

            var idsCriticos = new HashSet<int>(insumosNivelesCriticos.Select(i => i.id_insumo));

            //Notificar primero insumos criticos

            foreach (var insumo in insumosNivelesCriticos)
            {
                NotificarObservadores(insumo, TipoAlerta.Critica);
            }

            //Notificar  insumos bajos
            foreach (var insumo in insumosNivelesBajos)
            {
                if (!idsCriticos.Contains(insumo.id_insumo))
                {
                    NotificarObservadores(insumo, TipoAlerta.Baja);
                }
            }
        }

        // Verificar un insumo específico
        public async Task VerificarInsumo(int idInsumo)
        {
            clsInsumo insumo = await _servicioInsumo.ConsultarPorIdAsync(idInsumo);
            if (insumo == null)
                return;

            TipoAlerta tipoAlerta = await _servicioInsumo.VerificarNivelPorIdAsync(idInsumo);

            if (tipoAlerta != TipoAlerta.Normal)
            {
                NotificarObservadores(insumo, tipoAlerta);
            }
        }

        // Este método se puede llamar después de cada actualización de cantidad
        public async void VerificarDespuesDeActualizar(int idInsumo)
        {
            await VerificarInsumo(idInsumo);
        }
    }
}