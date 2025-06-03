using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Clases
{
    public class clsLote
    {
        public int id_lote { get; set; }
        public int id_usuario { get; set; }
        public string variedad { get; set; }

        public DateTime inicio_siembra { get; set; }
        public string estado { get; set; }
        public DateTime fecha_fin_siembra { get; set; }
        public string ubicacion { get; set; }   
        public int cantidad_plantas { get; set; }
        public string observaciones { get; set; }
        public int id_cultivo { get; set; }

    }
}
