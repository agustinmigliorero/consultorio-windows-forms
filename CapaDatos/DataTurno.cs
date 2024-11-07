using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataTurno
    {
        public static List<Turno> VerTurnosPorMedico(int idMedico)
        {
            List<Turno> turnos = new List<Turno>();

            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "SELECT appointmentID, patientId, professionalId, dateTime, canceled, status FROM Appointments WHERE professionalId = " + idMedico.ToString();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    conexion.Open();
                    SqlDataReader dataReader = comando.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Turno turno = new Turno
                        {
                            IdTurno = Convert.ToInt32(dataReader["appointmentID"]),
                            IdPaciente = Convert.ToInt32(dataReader["patientId"]),
                            IdMedico = Convert.ToInt32(dataReader["professionalId"]),
                            Fecha = Convert.ToDateTime(dataReader["dateTime"]),
                            Cancelado = Convert.ToBoolean(dataReader["canceled"]),
                            Estado = dataReader["status"].ToString()
                        };
                        turnos.Add(turno);
                    }
                }
            }

            return turnos;
        }

        public static List<Turno> VerTurnosPorPaciente(int idPaciente)
        {
            List<Turno> turnos = new List<Turno>();

            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "SELECT appointmentID, patientId, professionalId, dateTime, canceled, status FROM Appointments WHERE patientId = " + idPaciente.ToString();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    conexion.Open();
                    SqlDataReader dataReader = comando.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Turno turno = new Turno
                        {
                            IdTurno = Convert.ToInt32(dataReader["appointmentID"]),
                            IdPaciente = Convert.ToInt32(dataReader["patientId"]),
                            IdMedico = Convert.ToInt32(dataReader["professionalId"]),
                            Fecha = Convert.ToDateTime(dataReader["dateTime"]),
                            Cancelado = Convert.ToBoolean(dataReader["canceled"]),
                            Estado = dataReader["status"].ToString()
                        };
                        turnos.Add(turno);
                    }
                }
            }

            return turnos;
        }
    }
}
