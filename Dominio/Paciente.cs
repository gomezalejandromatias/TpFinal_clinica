using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Paciente
    {
        public int Idpaciente { get; set; }
         public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }
        public string Direccion { get; set; }
        public int Celular { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public string Email { get; set; }
    }
}
