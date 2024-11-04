using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        public SByte IdPaciente { get; set; }
        public string HistoriaClinica { get; set; }

        public Paciente() { 
        
        }
        public Paciente(SByte idPaciente, string nombre, string apellido, string dni, string telefono, string historiaClinica) {
            IdPaciente = idPaciente;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            HistoriaClinica = historiaClinica;
        }
    }
}
