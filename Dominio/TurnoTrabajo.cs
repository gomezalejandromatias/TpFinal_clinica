using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TurnoTrabajo
    {
         public int IdturnoTrabajo { get; set; }
        public Medico Medico { get; set; }
        public Especialidad Especialidad { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin{ get; set; }
        public Consultorio Consultorio { get; set; }
        public bool Activo { get; set; }    





    }
}
