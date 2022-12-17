using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace capaDatos
{
    public class cd_frEdificios
    {
        private cd_conexionDB conexion = new cd_conexionDB();

        SqlCommand sql = new SqlCommand();
        SqlDataReader reader;
        DataTable tablaEdificio = new DataTable();

        public bool insertEdificio(string Edificio)
        {
            if (Edificio == "")
            {
                return false;
            }
            else
            {
                sql.Connection = conexion.AbrirConexion();
                sql.CommandText = "insertEdificio";
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Edificio", Edificio);

                reader = sql.ExecuteReader();
                return true;
                conexion.CerrarConexion();
            }
        }

        public bool deleteEdificio(int idEdificio)
        {
            if (idEdificio == 0)
            {
                return false;
            }
            else
            {
                sql.Connection = conexion.AbrirConexion();
                sql.CommandText = "deleteEdificio";
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@id", idEdificio);

                reader = sql.ExecuteReader();
                return true;
                conexion.CerrarConexion();
            }
        }

        public DataTable selectEdificios()
        {
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectAllEdificios";
            sql.CommandType = CommandType.StoredProcedure;
            reader = sql.ExecuteReader();
            tablaEdificio.Load(reader);
            conexion.CerrarConexion();
            return tablaEdificio;
        }

        public bool selectAllEdificios(int id)
        {
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectAllEdificio";
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@id", id);
            reader = sql.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cd_EdificioCache.idEdificio = reader.GetInt32(0);
                    cd_EdificioCache.Edificio = reader.GetString(1);
                }
                return true;
            }
            else
                return false;
            conexion.CerrarConexion();
        }


    }
}
