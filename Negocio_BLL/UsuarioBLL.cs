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
        public int Login(string us, string pw) 
        {
            LoginUsuario Autenticar = new LoginUsuario();
            Encriptador SecPass = new Encriptador();
            int AuthOK = Autenticar.Login(us, SecPass.Encriptar(pw));
            if (AuthOK == 1)
            {
                
            }
            return AuthOK;
        }
    }
}
