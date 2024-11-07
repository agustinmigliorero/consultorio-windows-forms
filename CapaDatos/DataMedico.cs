using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class DataMedico
    {
        public static List<Medico> VerMedicosPorEspecialidad(SByte idEspecialidad)
        {
            List<Medico> medicos = new List<Medico>();
            SqlConnection conexion = new SqlConnection("Server=Agus-PC;Database=Clinic;User Id=sa;Password=1234;TrustServerCertificate=True;");
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT professionalId, firstName, lastName , dni, mobilePhone, email FROM Professionals WHERE specialtyId = " + idEspecialidad.ToString() + " order by lastName");
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                medicos.Add(new Medico(Convert.ToSByte(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString()));
            }
            return medicos;
        }

        public static Medico VerMedico(SByte idMedico) { 
            
        }
    }
}

