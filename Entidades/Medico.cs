using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Persona
    {
        public SByte IdMedico { get; set; }

        public string Email { get; set; }
        public Medico() { }
        public Medico(SByte idMedico, string nombre, string apellido, string dni, string telefono, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            IdMedico = idMedico;
            Email = email;
        }
    }
}
