using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
using Entidad_BE;
using Acceso_DAL;
using System.Data;

namespace Negocio_BLL
{
    public class GestionBLL
    {
        GestionUsuario GestionUs;
        public DataTable ObtenerUsuarios()
        {
            GestionUs = new GestionUsuario();
            DataTable dt = new DataTable();
            dt = GestionUs.ObtenerUsuarios();
            return dt;
        }


    }
}
