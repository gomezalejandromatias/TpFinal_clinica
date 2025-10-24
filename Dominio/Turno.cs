using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {

        public int Idturno { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public int DuracionMinutos { get; set; }



        Especialidad Especialidad { get; set; }
        Consultorio Consultorio { get; set; }
        Medico Medico { get; set; }
        Paciente Paciente { get; set; }

       




    }
}
