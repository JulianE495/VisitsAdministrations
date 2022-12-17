using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class cn_EdificiosModel
    {
        cd_frEdificios edificio = new cd_frEdificios();
        public bool insertEdificio(string Edificio)
        {
            return edificio.insertEdificio(Edificio);
        }
        public bool deleteEdificio(int idEdificio)
        {
            return edificio.deleteEdificio(idEdificio);
        }
        public DataTable mostrarEdificioTable()
        {
            DataTable tabla = new DataTable();
            tabla = edificio.selectEdificios();
            return tabla;
        }
        public bool selectEdificios(int id)
        {
            return edificio.selectAllEdificios(id);
        }
    }
}
