using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class cd_frVisitas
    {
        private cd_conexionDB conexion = new cd_conexionDB();

        SqlCommand sql = new SqlCommand();
        SqlDataReader reader;

        public bool insertVisit(string vNombre, string vApellido, string vCorreo, string vCarrera, string vHoraEntrada, string vHoraSalida, string vEdificio, string vAula, byte[] vImage, string vMotivoVisita)
        {
            if (vNombre == "" || vApellido == "" || vCorreo == "" || vCarrera == "" || vHoraEntrada == "" || vHoraSalida == "" || vEdificio == "" || vAula == "" || vMotivoVisita == "" || vImage == null)
            {
                return false;
            }
            else
            {
                sql.Connection = conexion.AbrirConexion();
                sql.CommandText = "insertVisit";
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Nombre", vNombre);
                sql.Parameters.AddWithValue("@Apellido", vApellido);
                sql.Parameters.AddWithValue("@Correo", vCorreo);
                sql.Parameters.AddWithValue("@Carrera", vCarrera);
                sql.Parameters.AddWithValue("@HoraEntrada", vHoraEntrada);
                sql.Parameters.AddWithValue("@HoraSalida", vHoraSalida);
                sql.Parameters.AddWithValue("@Edificio", vEdificio);
                sql.Parameters.AddWithValue("@Aula", vAula);
                sql.Parameters.AddWithValue("@vImage", vImage);
                sql.Parameters.AddWithValue("@motivoVisita", vMotivoVisita);

                reader = sql.ExecuteReader();
                return true;
                conexion.CerrarConexion();
            }
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
        public DataTable selectAula(int IDEdificio)
        {
            DataTable aulas = new DataTable();
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectAula";
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Edificio", IDEdificio);
            reader = sql.ExecuteReader();
            aulas.Load(reader);
            conexion.CerrarConexion();
            return aulas;
        }
        public DataTable selectCarrera()
        {
            DataTable carreras = new DataTable();
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectCarreras";
            sql.CommandType = CommandType.StoredProcedure;
            reader = sql.ExecuteReader();
            carreras.Load(reader);
            conexion.CerrarConexion();
            return carreras;
        }
        public DataTable selectMotivoVisita()
        {
            DataTable motivoVisita = new DataTable();
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectMotivoVisita";
            sql.CommandType = CommandType.StoredProcedure;
            reader = sql.ExecuteReader();
            motivoVisita.Load(reader);
            conexion.CerrarConexion();
            return motivoVisita;
        }
        public void validacionRol()
        {
            if (cd_userCache.IdRol == 0)
            {
                //blablabla
            }
            if (cd_userCache.IdRol == 1)
            {
                //blablabla
            }
        }
    }
}
