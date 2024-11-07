using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agenda
    {
        public SByte IdAgenda { get; set; }
        public string Dia { get; set; }
        public TimeSpan Horario { get; set; }
        public int IdMedico { get; set; }

        // Constructor sin parámetros
        public Agenda() { }

        // Constructor con parámetros
        public Agenda(SByte idAgenda, string dia, TimeSpan horario, int idMedico)
        {
            IdAgenda = idAgenda;
            Dia = dia;
            Horario = horario;
            IdMedico = idMedico;
        }

    }
}

