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
            SqlConnection conexion = new SqlConnection("Server=NOTEBOOK-FACU;Database=Clinic;User Id=sa;Password=1234;TrustServerCertificate=True;");
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
            SqlConnection conexion = new SqlConnection("Server=Agus-PC;Database=Clinic;User Id=sa;Password=1234;TrustServerCertificate=True;");
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
                paciente.Estado = dataReader[9].ToString() == "1";
            }
            return paciente;
        }
    }
}
