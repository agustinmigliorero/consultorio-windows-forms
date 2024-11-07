using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;



namespace CapaDatos
{
    internal class Base
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
            command.CommandText = "SELECT professionalId, firstName, lastName, FROM Professionals WHERE specialtyId = " + especialidad + " order by lastName";
            command.Connection = connect;
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Medicos.Add(new Medico(Convert.ToSByte(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString()));
            }
            return Medicos;

        }
    }
}
