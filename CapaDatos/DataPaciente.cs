using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataPaciente
    {
        public static List<Paciente> VerPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();
            SqlConnection conexion = new SqlConnection(StringConnection.StrConnection);

            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT patientId, firstName, lastName , dni, mobilePhone, medicalRecordNumber FROM Patients");
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                pacientes.Add(new Paciente(Convert.ToSByte(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString()));
            }
            return pacientes;
        }

        public static Paciente VerPaciente(SByte idPaciente)
        {
            SqlConnection conexion = new SqlConnection(StringConnection.StrConnection);

            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT patientId, firstName, lastName , dni, mobilePhone, phone, medicalRecordNumber, birthDate, notes, status FROM Patients WHERE patientId = " + idPaciente + " order by lastName");
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = comando.ExecuteReader();
            Paciente paciente = new Paciente();
            while (dataReader.Read())
            {
                paciente.IdPaciente = Convert.ToSByte(dataReader[0]);
                paciente.Nombre = dataReader[1].ToString();
                paciente.Apellido = dataReader[2].ToString();
                paciente.DNI = dataReader[3].ToString();
                paciente.Telefono = dataReader[4].ToString();
                paciente.TelefonoFijo = dataReader[5].ToString();
                paciente.HistoriaClinica = dataReader[6].ToString();
                paciente.FechaNacimiento = DateTime.Parse(dataReader[7].ToString());
                paciente.Notas = dataReader[8].ToString();
                paciente.Estado = dataReader[9].ToString();
            }
            return paciente;
        }

        public static void CrearPaciente(Paciente nuevoPaciente)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "INSERT INTO Patients (firstName, lastName, dni, mobilePhone, phone, medicalRecordNumber, birthDate, notes, status) " +
                               "VALUES (@FirstName, @LastName, @DNI, @MobilePhone, @Phone, @MedicalRecordNumber, @BirthDate, @Notes, @Status)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@FirstName", nuevoPaciente.Nombre);
                    comando.Parameters.AddWithValue("@LastName", nuevoPaciente.Apellido);
                    comando.Parameters.AddWithValue("@DNI", nuevoPaciente.DNI);
                    comando.Parameters.AddWithValue("@MobilePhone", nuevoPaciente.Telefono);
                    comando.Parameters.AddWithValue("@Phone", nuevoPaciente.TelefonoFijo);
                    comando.Parameters.AddWithValue("@MedicalRecordNumber", nuevoPaciente.HistoriaClinica);
                    comando.Parameters.AddWithValue("@BirthDate", nuevoPaciente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@Notes", nuevoPaciente.Notas);
                    comando.Parameters.AddWithValue("@Status", nuevoPaciente.Estado);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void EditarPaciente(Paciente paciente)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "UPDATE Patients SET firstName = @FirstName, lastName = @LastName, dni = @DNI, " +
                               "mobilePhone = @MobilePhone, phone = @Phone, medicalRecordNumber = @MedicalRecordNumber, " +
                               "birthDate = @BirthDate, notes = @Notes WHERE patientId = @PatientId";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@PatientId",Convert.ToInt32(paciente.IdPaciente));
                    comando.Parameters.AddWithValue("@FirstName", paciente.Nombre);
                    comando.Parameters.AddWithValue("@LastName", paciente.Apellido);
                    comando.Parameters.AddWithValue("@DNI", paciente.DNI);
                    comando.Parameters.AddWithValue("@MobilePhone", paciente.Telefono);
                    comando.Parameters.AddWithValue("@Phone", paciente.TelefonoFijo);
                    comando.Parameters.AddWithValue("@MedicalRecordNumber", paciente.HistoriaClinica);
                    comando.Parameters.AddWithValue("@BirthDate", paciente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@Notes", paciente.Notas);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }


        public static void EditarEstadoPaciente(int idPaciente, bool nuevoEstado)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "UPDATE Patients SET status = @Status WHERE patientId = @PatientId";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@PatientId", idPaciente);
                    comando.Parameters.AddWithValue("@Status", nuevoEstado ? 1 : 0);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarPaciente(SByte idPaciente)
        {
            using (SqlConnection conexion = new SqlConnection(StringConnection.StrConnection))
            {
                string query = "DELETE FROM Patients WHERE patientId = @PatientId";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@PatientId", idPaciente);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }


    }
}
