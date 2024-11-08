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

        public string TelefonoFijo { get; set; }
        public string HistoriaClinica { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Notas { get; set; }

        public string Estado {  get; set; }

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

        public Paciente(string nombre, string apellido, string dni, string telefono, string telefonoFijo, string historiaClinica, DateTime fechaNacimiento, string notas, string estado = "True")
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            TelefonoFijo = telefonoFijo;
            HistoriaClinica = historiaClinica;
            FechaNacimiento = fechaNacimiento;
            Notas = notas;
            Estado = estado;
        }

        public Paciente(SByte idPaciente, string nombre, string apellido, string dni, string telefono, string telefonoFijo, string historiaClinica, DateTime fechaNacimiento, string notas, string estado = "True")
        {
            IdPaciente = idPaciente;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            TelefonoFijo = telefonoFijo;
            HistoriaClinica = historiaClinica;
            FechaNacimiento = fechaNacimiento;
            Notas = notas;
            Estado = estado;
        }
    }
}
