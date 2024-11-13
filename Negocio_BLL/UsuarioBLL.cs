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

        public int Login(UsuarioBE us) 
        {
            int AuthOK;
            us.pass = Encriptador.EncriptarIrrev(us.pass);
            if (SessionManager.GetInstance.logged == false)
            {
                AuthOK = mpUsuario.Login(us);
                if (AuthOK == 1)
                {
                    SessionManager.GetInstance.Login(us);
                    maxIntentos = 3;
                }
            }
            else
            {
                usuario = SessionManager.GetInstance.UsuarioActual();
                if ((usuario.user == us.user) && (usuario.pass == us.pass))
                {
                    AuthOK = 6;
                    maxIntentos = 3;
                }
                else {  AuthOK = 7; }
            }
            if((AuthOK != 1) || (AuthOK != 7)) { maxIntentos--; } 
            if(maxIntentos == 0)
            {
                usuario = new UsuarioBE();
                usuario.user = us.user;
                usuario.pass = " ";
                mpUsuario.ActualizarBloqueo(usuario, true); 
                AuthOK = 5;
            }
            return AuthOK;
        }

        public int VerifUsuario (UsuarioBE us, int tipo)//tipo 0 = Verificar Actual -- tipo == 1 Verificar Nueva
        {
            string encPass = Encriptador.EncriptarIrrev(us.pass);
            if (SessionManager.GetInstance.UsuarioActual().pass == encPass)
            {
                maxIntentos = 3;
                return 1;//Usuario Verificado OK -- Nueva  = Anterior
            }
            else
            {
                if(tipo == 1)//Verificar Nueva
                {
                    SessionManager.GetInstance.UsuarioActual().pass = encPass;
                    mpUsuario.CambiarPass(SessionManager.GetInstance.UsuarioActual());
                    maxIntentos = 3;

                    return 2;//Cambio de pass ok
                }
                maxIntentos--;
                if(maxIntentos == 0)
                {
                    if(tipo == 0)//Verificar Actual
                    {
                        us.user = SessionManager.GetInstance.UsuarioActual().user;
                        us.pass = " ";
                        mpUsuario.ActualizarBloqueo(us, true);
                        return 2; //Falla Verificacion, Bloquea usuario
                    }
                    else 
                    {
                        maxIntentos = 3; 
                        return 3; 
                    }
                }
                return 0; //Reintentar
            }
        }

        public void Logout()
        {
            SessionManager.GetInstance.Logout();
        }

        public void DesbloquearUS(UsuarioBE us)
        {
            usuario = us;
            us.pass = Encriptador.EncriptarIrrev(us.pass);
            mpUsuario.ActualizarBloqueo(us, false);
        }

        public void CrearUsuario(UsuarioBE us)
        {
            usuario = us;
            us.pass = Encriptador.EncriptarIrrev(us.pass);
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

        public string GenerarPass(string ape, string dni)
        {
            string pass = ape.Substring(0, 3) + dni.Substring(0, 3);
            return pass;
        }
    }
}
