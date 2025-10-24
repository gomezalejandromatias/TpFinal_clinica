using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Idusuario {  get; set; }
        public string TipoUsuario { get; set; }

        public string Passwords { get; set; }

        public string Dni {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }




    }
}
