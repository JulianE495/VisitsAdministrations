using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class UserModel
    {
        cd_frLogin userDao = new cd_frLogin();

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
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
