using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class DataAgenda
    {
        public static List<Agenda> VerAgenda(SByte IdMedico) { 
            List<Agenda> agendas = new List<Agenda>();

            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "SELECT scheduleId, day, time, professionalId FROM Schedules WHERE professionalId = " + IdMedico.ToString();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    SqlDataReader dataReader = comando.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Agenda agenda = new Agenda
                        {
                            IdAgenda = Convert.ToInt32(dataReader["scheduleId"]),
                            Dia = dataReader["day"].ToString(),
                            Horario = TimeSpan.Parse(dataReader["time"].ToString()),
                            IdMedico = Convert.ToInt32(dataReader["professionalId"])
                        };
                        agendas.Add(agenda);
                    }
                }
            }
            return agendas;
        }
    }
}
