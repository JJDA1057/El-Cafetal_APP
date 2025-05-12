using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Cafetal_APP.Clases
{
    public class clsUsuario
    {
        public int id_usuario { get; set; }

        public string nombre { get; set; }

        public string correo { get; set; }

        public string contraseña { get; set; }

        public int id_rol { get; set; }

        public bool estado_verificacion { get; set; }

        public string codigo_verificacion { get; set; }

        public bool estado_usuario { get; set; }
    }
}
