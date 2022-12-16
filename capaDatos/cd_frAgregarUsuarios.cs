using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class cd_frAgregarUsuarios
    {
        private cd_conexionDB conexion = new cd_conexionDB();

        SqlCommand sql = new SqlCommand();
        SqlDataReader reader;

        public bool insertUser(string User, string Pass, string Nombre, string Apellido, int idRol, string Rol, string DOB, byte[] fotoPerfil)
        {
            if (User == "" || Pass == "" || Nombre == "" || Apellido == "" || DOB == "")
            {
                return false;
            }
            else
            {
                sql.Connection = conexion.AbrirConexion();
                sql.CommandText = "insertUser";
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@User", User);
                sql.Parameters.AddWithValue("@Pass", Pass);
                sql.Parameters.AddWithValue("@Nombre", Nombre);
                sql.Parameters.AddWithValue("@Apellido", Apellido);
                sql.Parameters.AddWithValue("@idRol", idRol);
                sql.Parameters.AddWithValue("@Rol", Rol);
                sql.Parameters.AddWithValue("@DOB", DOB);
                sql.Parameters.AddWithValue("@FotoPerfil", fotoPerfil);

                reader = sql.ExecuteReader();
                return true;
                conexion.CerrarConexion();
            }
        }
    }
}
