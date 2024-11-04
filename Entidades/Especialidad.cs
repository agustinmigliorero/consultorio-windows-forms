using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Especialidad
    {
        public SByte IdEspecialidad { get; set; }
        public string Nombre { get; set; }
        public Especialidad(sbyte idEspecialidad, string nombre) {
            IdEspecialidad = idEspecialidad;
            Nombre = nombre;
        }
    }
}
