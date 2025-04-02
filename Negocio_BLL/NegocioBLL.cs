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
    public class NegocioBLL
    {
        private MP_Usuario mpUsuario = new MP_Usuario();
        private MP_Producto mpProducto = new MP_Producto();

        public List<UsuarioBE> ListarUsuarios()
        {
            return mpUsuario.ListarUsuarios();
        }

        public List<ProductoBE> ObtenerProductos()
        {
            return mpProducto.ObtenerProductos();
        }
    }
}
