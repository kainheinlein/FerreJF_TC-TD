using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Entidad_BE;
using System.Configuration;

namespace Acceso_DAL
{
    public class MP_Usuario
    {
        AccesoDatos conexDB = new AccesoDatos();

        public DataTable ObtenerUsuarios()
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@tabla", "Usuarios");
            DataTable dt = conexDB.LeerTabla("SP_ExtTabla", parametros);
            return dt;
        }

        public int Login(UsuarioBE us)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@user", us.user);
            parametros[1] = new SqlParameter("@pass", us.pass);

            return conexDB.Consulta("SP_Login", parametros);
        }

        public void ActualizarBloqueo(UsuarioBE us, bool bloq)
        {
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("@Usuario", us.user);
            parametros[1] = new SqlParameter("@pass", us.pass);
            parametros[2] = new SqlParameter("@Bloqueado", bloq);

            conexDB.Escribir("SP_ActualizarBloqueado", parametros);
        }

        public void CrearUsuario (UsuarioBE us)
        {
            SqlParameter[] parametros = new SqlParameter[11];
            parametros[0] = new SqlParameter("@DNI", us.dni);
            parametros[1] = new SqlParameter("@Nombre", us.nomb);
            parametros[2] = new SqlParameter("@Apellido", us.ape);
            parametros[3] = new SqlParameter("@Usuario", us.user);
            parametros[4] = new SqlParameter("@Rol", us.rol);
            parametros[5] = new SqlParameter("@Contraseña", us.pass);
            parametros[6] = new SqlParameter("@Direccion", us.dir);
            parametros[7] = new SqlParameter("@Telefono", us.tel);
            parametros[8] = new SqlParameter("@Email", us.email);
            parametros[9] = new SqlParameter("@Activo", us.estado);
            parametros[10] = new SqlParameter("@Bloqueado", us.bloq);

            conexDB.Escribir("SP_CrearUsuario", parametros);
        }

        public void EliminarUsuario(UsuarioBE us)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("Usuario", us.user);

            conexDB.Escribir("SP_ElimUsuario", parametros);
        }

        public void ActualizarUsuario(UsuarioBE us)
        {
            SqlParameter[] parametros = new SqlParameter[10];
            parametros[0] = new SqlParameter("Codigo", us.cod);
            parametros[1] = new SqlParameter("@DNI", us.dni);
            parametros[2] = new SqlParameter("@Nombre", us.nomb);
            parametros[3] = new SqlParameter("@Apellido", us.ape);
            parametros[4] = new SqlParameter("@Usuario", us.user);
            parametros[5] = new SqlParameter("@Rol", us.rol);
            parametros[6] = new SqlParameter("@Direccion", us.dir);
            parametros[7] = new SqlParameter("@Telefono", us.tel);
            parametros[8] = new SqlParameter("@Email", us.email);
            parametros[9] = new SqlParameter("@Activo", us.estado);

            conexDB.Escribir("SP_ActualizarUs", parametros);
        }

        public void CambiarPass(UsuarioBE us)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@Usuario", us.user);
            parametros[1] = new SqlParameter("@pass", us.pass);

            conexDB.Escribir("SP_CambiarPass", parametros);
        }

    }
}       
