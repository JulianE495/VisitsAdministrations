using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class cn_consultarVisits
    {
        cd_frConsultarVisitas consultarVisitas = new cd_frConsultarVisitas();
        public DataTable MostrarVisitTable()
        {
            DataTable tabla = new DataTable();
            tabla = consultarVisitas.selectVisit();
            return tabla;
        }
        public DataTable MostrarVisitTableEdificio(string edificio)
        {
            DataTable tabla = new DataTable();
            tabla = consultarVisitas.selectVisitEdificio(edificio);
            return tabla;
        }
    }
}
