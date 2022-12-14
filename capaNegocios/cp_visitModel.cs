using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class cp_visitModel
    {
        cd_frVisitas visitDAO = new cd_frVisitas();

        public bool guardarVisita(string vNombre, string vApellido, string vCorreo, string vCarrera, string vHoraEntrada, string vHoraSalida, string vEdificio, string vAula, byte[] vImage, string vMotivoVisita)
        {
            return visitDAO.insertVisit(vNombre, vApellido, vCorreo, vCarrera, vHoraEntrada, vHoraSalida, vEdificio, vAula, vImage, vMotivoVisita);
        }
    }
}
