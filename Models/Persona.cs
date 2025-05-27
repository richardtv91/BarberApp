using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberApp.Models
{
    public  class Persona
    {
        public int Idpersona { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string email_user { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Rol { get; set; } // Puede ser "Cliente" o "Barbero"
        public DateTime Datecreated { get; set; }
        public int Status { get; set; } // 1 para activo, 0 para inactivo


    }
}
