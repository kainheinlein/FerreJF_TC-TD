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
        private MP_Usuario mpUsuario;
        public UsuarioBE usuario;
        public DataTable ObtenerUsuarios()
        {
            mpUsuario = new MP_Usuario();
            DataTable dt = new DataTable();
            dt = mpUsuario.ObtenerUsuarios();
            return dt;
        }
    }
}
