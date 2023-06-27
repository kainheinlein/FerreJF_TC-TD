using System;
using System.Collections.Generic;
using System.Linq;
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
        private GestionUsuario gestion;

        public int Login(string us, string pw) 
        {
            LoginUsuario Autenticar = new LoginUsuario();
            Encriptador SecPass = new Encriptador();
            int AuthOK = Autenticar.Login(us, SecPass.Encriptar(pw));
            if (AuthOK == 3 & maxIntentos > 0)
            {
                maxIntentos--;
            }
            if (maxIntentos == 0) 
            { 
                gestion = new GestionUsuario();
                gestion.ActualizarBloqueo(us, true);
                AuthOK = 4; 
            }
            if (AuthOK == 1)
            {
                usuario = new UsuarioBE();
                usuario.user = us;
                SessionManager.GetInstance.Login(usuario);
            }
            return AuthOK;
        }

        public void Logout()
        {
            SessionManager.GetInstance.Logout();
        }
    }
}
