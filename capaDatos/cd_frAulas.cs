using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class cd_frAulas
    {
        private cd_conexionDB conexion = new cd_conexionDB();

        SqlCommand sql = new SqlCommand();
        SqlDataReader reader;
        DataTable tablaAula = new DataTable();

        public bool insertAula(string Aula, int idEdificio)
        {
            if (Aula == "")
            {
                return false;
            }
            else
            {
                sql.Connection = conexion.AbrirConexion();
                sql.CommandText = "insertAulas";
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Aula", Aula);
                sql.Parameters.AddWithValue("@idEdificio", idEdificio);

                reader = sql.ExecuteReader();
                return true;
                conexion.CerrarConexion();
            }
        }

        public bool deleteAula(int idAula, string Aula)
        {
            if (idAula == 0 || Aula == "")
            {
                return false;
            }
            else
            {
                sql.Connection = conexion.AbrirConexion();
                sql.CommandText = "deleteAula";
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@idAula", idAula);
                sql.Parameters.AddWithValue("@Aula", Aula);

                reader = sql.ExecuteReader();
                return true;
                conexion.CerrarConexion();
            }
        }

        public DataTable selectAulas()
        {
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectAllAulas";
            sql.CommandType = CommandType.StoredProcedure;
            reader = sql.ExecuteReader();
            tablaAula.Load(reader);
            conexion.CerrarConexion();
            return tablaAula;
        }

        public bool selectAllAulas(int id)
        {
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectAllAulasId";
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@idAula", id);
            reader = sql.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cd_AulasCache.idAula = reader.GetInt32(0);
                    cd_AulasCache.Aula = reader.GetString(1);
                    cd_AulasCache.idEdificio = reader.GetInt32(2);
                }
                return true;
            }
            else
                return false;
            conexion.CerrarConexion();
        }
    }
}
