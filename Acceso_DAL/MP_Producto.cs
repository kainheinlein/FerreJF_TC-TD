
/*Armar Clase producto y finalizar carga de lista*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad_BE;

namespace Acceso_DAL
{
    public class MP_Producto
    {
        AccesoDatos conexDB = new AccesoDatos();

        public List<ProductoBE> ObtenerProductos()
        {
            List<ProductoBE> productos = new List<ProductoBE>();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@tabla", "Productos");
            DataTable dt = conexDB.LeerTabla("SP_ExtTabla", parametros);
            foreach (DataRow dr in dt.Rows)
            {
                ProductoBE prod = new ProductoBE();
                productos.Add(prod);
            }
            return productos;
        }
    }
}
