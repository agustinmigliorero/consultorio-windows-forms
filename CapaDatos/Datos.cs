using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;



namespace CapaDatos
{
    public class Datos
    {
        public static List<Especialidad> CargarEspecialidades()
        {
            List<Especialidad> Especialidades = new List<Especialidad>();
            SqlConnection connect = new SqlConnection("Server=NOTEBOOK-FACU;Database=Clinic;User Id=sa;Password=1234;TrustServerCertificate=True;");
            connect.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT specialtyId, specialtyName FROM Specialties ORDER BY specialtyName";
            command.Connection = connect;
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Especialidades.Add(new Especialidad(Convert.ToSByte(dr[0]), dr[1].ToString()));
            }
            return Especialidades;
        }
        public static List<Medico> ListadoMedicos(SByte especialidad)
        {
            List<Medico> Medicos = new List<Medico>();
            SqlConnection connect = new SqlConnection("Server=NOTEBOOK-FACU;Database=Clinic;User Id=sa;Password=1234;TrustServerCertificate=True;");
            connect.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT professionalId, lastName,firstName ,dni ,email,mobilePhone FROM Professionals WHERE specialtyId = " + especialidad + " order by lastName";
            command.Connection = connect;
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Medicos.Add(new Medico(Convert.ToSByte(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString()));
            }
            return Medicos;

        }
        public static List<Paciente> ListadoPacientes()
        {
            List<Paciente> Pacientes = new List<Paciente>();
            SqlConnection connect = new SqlConnection("Server=NOTEBOOK-FACU;Database=Clinic;User Id=sa;Password=1234;TrustServerCertificate=True;");
            connect.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT patientId, lastName , firstName, dni  FROM patients order by lastName";
            command.Connection = connect;
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Pacientes.Add(new Paciente(Convert.ToSByte(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
            return Pacientes;

        }
        public static Paciente DatosPaciente(sbyte idpaciente)
        {
            SqlConnection connect = new SqlConnection("Server=NOTEBOOK-FACU;Database=Clinic;User Id=sa;Password=1234;TrustServerCertificate=True;");
            connect.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT patientId, lastName , firstName , medicalRecordNumber , dni , FROM patients WHERE patientId = " + idpaciente;
            command.Connection = connect;
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Paciente Datosencotrados = new Paciente(Convert.ToSByte(dr[0]), dr[1].ToString(), dr[2].ToString(), Convert.ToInt32(dr[3]), dr[4].ToString());
                return Datosencotrados;
            }
            else
            {
                throw new Exception("No se encontró ningún paciente con ese ID.");
            }
        }
    }
}
