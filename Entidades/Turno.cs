using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public DateTime Fecha { get; set; }
        public bool Cancelado { get; set; }
        public string Estado { get; set; }

        public Turno() { }

        
        public Turno(int idTurno, int idPaciente, int idMedico, DateTime fecha, bool cancelado = false, string estado = "Pending")
        {
            IdTurno = idTurno;
            IdPaciente = idPaciente;
            IdMedico = idMedico;
            Fecha = fecha;
            Cancelado = cancelado;
            Estado = estado;
        }
    }
}

