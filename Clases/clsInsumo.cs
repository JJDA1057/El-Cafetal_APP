using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Clases
{
    public  class clsInsumo
    {
        public int id_insumo { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public int id_proveedor { get; set; }
        public int cantidad { get; set; }
        public DateTime f_entrega { get; set; }


    }
}
