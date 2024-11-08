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

        public static List<Turno> VerTurnosPorMedicoYFecha(int idMedico, DateTime fecha)
        {
            List<Turno> turnos = new List<Turno>();

            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "SELECT appointmentID, patientId, professionalId, dateTime, canceled, status " +
                               "FROM Appointments WHERE professionalId = @ProfessionalId AND CAST(dateTime AS DATE) = CAST(@Fecha AS DATE)";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@ProfessionalId", idMedico);
                    comando.Parameters.AddWithValue("@Fecha", fecha);

                    conexion.Open();
                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
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
            }
            return turnos;
        }

        public static void CrearTurno(Turno turno)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "INSERT INTO Appointments (patientId, professionalId, dateTime, canceled, status) " +
                               "VALUES (@PatientId, @ProfessionalId, @DateTime, @Canceled, @Status)";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@PatientId", turno.IdPaciente);
                    comando.Parameters.AddWithValue("@ProfessionalId", turno.IdMedico);
                    comando.Parameters.AddWithValue("@DateTime", turno.Fecha);
                    comando.Parameters.AddWithValue("@Canceled", false);
                    comando.Parameters.AddWithValue("@Status", "Pending");

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void CancelarTurno(int idTurno)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "UPDATE Appointments SET canceled = @Canceled WHERE appointmentID = @AppointmentID";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Canceled", true);
                    comando.Parameters.AddWithValue("@AppointmentID", idTurno);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void EditarTurno(int idTurno, string estado)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "UPDATE Appointments SET status = @Status WHERE appointmentID = @AppointmentID";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Status", estado);
                    comando.Parameters.AddWithValue("@AppointmentID", idTurno);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }


    }
}
