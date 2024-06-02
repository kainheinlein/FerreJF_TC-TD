using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Acceso_DAL;
using Entidad_BE;
using Servicios;

namespace Negocio_BLL
{
    public class UsuarioBLL
    {
        public int maxIntentos = 3;
        private UsuarioBE usuario;
        private MP_Usuario mpUsuario = new MP_Usuario();

        public int Login(string us, string pw) 
        {
            int AuthOK;
            if (SessionManager.GetInstance.logged == false)
            {
                AuthOK = mpUsuario.Login(us, Encriptador.EncriptarIrrev(pw));
                if (AuthOK == 1)
                {
                    usuario = new UsuarioBE();
                    usuario.user = us;
                    SessionManager.GetInstance.Login(usuario);
                    maxIntentos = 3;
                }
            }
            else
            {
                usuario = SessionManager.GetInstance.UsuarioActual();
                if (usuario.user == us) { AuthOK = 6; }
                else {  AuthOK = 7; }
            }
            if(AuthOK != 1) { maxIntentos--; } 
            if(maxIntentos == 0)
            {
                mpUsuario.ActualizarBloqueo(us, true);
                AuthOK = 5;
            }
            return AuthOK;
        }

        public void Logout()
        {
            SessionManager.GetInstance.Logout();
        }

        public void DesbloquearUS(UsuarioBE us)
        {
            mpUsuario.ActualizarBloqueo(us.user, false);
        }

        public void CrearUsuario(UsuarioBE us)
        {
            mpUsuario.CrearUsuario(us);
        }

        public void EliminarUs(UsuarioBE us)
        {
            mpUsuario.EliminarUsuario(us);
        }

        public void ActualizarUsuario(UsuarioBE us)
        {
            mpUsuario.ActualizarUsuario(us);
        }
    }
}
