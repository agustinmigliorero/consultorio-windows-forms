using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataEspecialidad
    {
        public static List<Especialidad> CargarEspecialidades()
        {
            List<Especialidad> Especialidades = new List<Especialidad>();
            SqlConnection connect = new SqlConnection(StringConnection.StrConnection);
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
    }
}
