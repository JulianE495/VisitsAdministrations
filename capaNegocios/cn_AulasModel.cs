using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class cn_AulasModel
    {
        cd_frAulas aulas = new cd_frAulas();

        public bool insertAula(string Aula, int idEdificio)
        {
            return aulas.insertAula(Aula, idEdificio);
        }
        public bool deleteAula(int idAula, string Aula)
        {
            return aulas.deleteAula(idAula, Aula);
        }
        public DataTable mostrarAulasTable()
        {
            DataTable tabla = new DataTable();
            tabla = aulas.selectAulas();
            return tabla;
        }
        public bool selectAulas(int idAula)
        {
            return aulas.selectAllAulas(idAula);
        }


    }
}
