using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Clases
{
    public class clsAdm_insumo
    {
        public int id_aplica { get; set; }
        public int  id_lote { get; set; }
        public int  id_insumo { get; set; }
        public int  cant_usada { get; set; }
        public DateTime fecha_aplic { get; set; }
        public int id_proveedor { get; set; }
    }
}
