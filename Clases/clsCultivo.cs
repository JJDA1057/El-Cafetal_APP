using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Clases
{
    public class clsCultivo
    {
        public int id_cultivo { get; set; }
        
        public string nombre { get; set; }

        public string ubicacion { get; set; }

        public DateTime fecha_inicio { get; set; }

        public DateTime fecha_fin { get; set; }

        public int id_usuario { get; set; }
    }
}
