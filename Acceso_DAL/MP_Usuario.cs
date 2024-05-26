using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Acceso_DAL
{
    public class MP_Usuario
    {
        AccesoDatos conexDB = new AccesoDatos();

        public DataTable ObtenerUsuarios()
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@tabla", "Usuarios");
                DataTable dt = conexDB.LeerTabla("SP_ExtTabla", parametros);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Login(string username, string password)
        {
            try
            {
                int result;

                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@user", username);
                parametros[1] = new SqlParameter("@pass", password);
                result = conexDB.Consulta("SP_Login", parametros);

                return result;
            }
            catch { return -1; }
        }

        public void ActualizarBloqueo(string us, bool bloq)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@Usuario", us);
                parametros[1] = new SqlParameter("@Bloqueado", bloq);
                conexDB.Escribir("SP_ActualizarBloqueado",parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}       
