using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class cn_addUserModel
    {
        cd_frAgregarUsuarios addUser = new cd_frAgregarUsuarios();

        public bool insertUser(string User, string Pass, string Nombre, string Apellido, int idRol, string Rol, string DOB, byte[] fotoPerfil)
        {
            return addUser.insertUser(User, Pass, Nombre, Apellido, idRol, Rol, DOB, fotoPerfil);
        }
        public DataTable mostarUserTable()
        {
            DataTable tabla = new DataTable();
            tabla = addUser.selectUsers();
            return tabla;
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
