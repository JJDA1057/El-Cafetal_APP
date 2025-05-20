using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Clases
{
    public class clsPlanta
    {
        public int id_planta { get; set; }
        public int id_lote { get; set; }
        public DateTime fecha_plantacion { get; set; }
        public string estado { get; set; }
        public string observaciones { get; set; }
    }

}
