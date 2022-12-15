using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class cd_frConsultarVisitas
    {
        private cd_conexionDB conexion = new cd_conexionDB();

        SqlCommand sql = new SqlCommand();
        SqlDataReader reader;
        DataTable tablaVisits = new DataTable();

        public DataTable selectVisit()
        {
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectVisit";
            sql.CommandType = CommandType.StoredProcedure;
            reader = sql.ExecuteReader();
            tablaVisits.Load(reader);
            conexion.CerrarConexion();
            return tablaVisits;

        }

        public DataTable selectVisitEdificio(string cvEdificio)
        {
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectVisitEdificio";
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Edificio", cvEdificio);
            reader = sql.ExecuteReader();
            tablaVisits.Load(reader);
            conexion.CerrarConexion();
            return tablaVisits;
        }
        public DataTable selectEdificio()
        {
            DataTable edificios = new DataTable();
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectEdificio";
            sql.CommandType = CommandType.StoredProcedure;
            reader = sql.ExecuteReader();
            edificios.Load(reader);
            conexion.CerrarConexion();
            return edificios;
        }
    }
}
