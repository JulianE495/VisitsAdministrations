using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaDatos
{
    public class cd_frLogin
    {
        private cd_conexionDB conexion = new cd_conexionDB();
        

        SqlCommand sql = new SqlCommand();
        SqlDataReader reader;
        
        
        public bool Login(string user, string pass)
        {
            int IdRol;
            sql.Connection = conexion.AbrirConexion();
            sql.CommandText = "selectUserPass";
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@user", user);
            sql.Parameters.AddWithValue("@pass", pass);
            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            
            reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cd_userCache.IdUser = reader.GetInt32(0);
                    cd_userCache.LoginName = reader.GetString(1);
                    cd_userCache.Password = reader.GetString(2);
                    cd_userCache.Name = reader.GetString(3);
                    cd_userCache.LastName = reader.GetString(4);
                    cd_userCache.IdRol = reader.GetInt32(5);
                    cd_userCache.Rol = reader.GetString(6);

                }
                return true;
            }
            else
                return false;
            conexion.CerrarConexion();
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
