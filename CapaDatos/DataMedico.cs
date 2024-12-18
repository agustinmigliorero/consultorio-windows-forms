﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataMedico
    {
        public static List<Medico> VerMedicosPorEspecialidad(SByte idEspecialidad)
        {
            List<Medico> medicos = new List<Medico>();
            SqlConnection conexion = new SqlConnection(StringConnection.StrConnection);
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
            Medico medico = new Medico();
            SqlConnection conexion = new SqlConnection(StringConnection.StrConnection);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT professionalId, firstName, lastName , dni, mobilePhone, email FROM Professionals WHERE professionalId = " + idMedico);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                medico.IdMedico = Convert.ToSByte(dataReader["professionalId"]);
                medico.Nombre = dataReader["firstName"].ToString();
                medico.Apellido = dataReader["lastName"].ToString();
                medico.DNI = dataReader["dni"].ToString();
                medico.Telefono = dataReader["mobilePhone"].ToString();
                medico.Email = dataReader["email"].ToString();
                
            }
            return medico;
        }

    }
}

