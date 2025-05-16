using API_CAFETAL;
using El_Cafetal_APP.Clases;
using El_Cafetal_APP.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace API_CAFETAL.Interface
{
    public interface IInventarioObservableW
    {

        void AgregarObservador(IInventarioObserver observador);
        void EliminarObservador(IInventarioObserver observador);
        void NotificarObservadores(clsInsumo insumo, TipoAlerta tipoAlerta);

    }
    public interface IInventarioObserver
    {
        void Actualizar(clsInsumo insumo, TipoAlerta tipoAlerta);
    }
}