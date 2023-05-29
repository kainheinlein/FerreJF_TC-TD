using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad_BE;

namespace Servicios
{
    public class SessionManager
    {
        private static SessionManager _sesion;
        private static object _lock = new Object();//Bloquear acceso multihilo
        UsuarioBE _usuario;

        public static SessionManager GetInstance
        {
            get
            {
                if (_sesion == null) _sesion = new SessionManager();
                return _sesion;
            }
        }

        public static void Login(UsuarioBE usuario)
        {
            lock(_lock)
            {
                if (_sesion == null)
                {
                    _sesion = new SessionManager();
                    _sesion._usuario = usuario;
                }
                else
                {
                    
                }
            }


        }
        private SessionManager() 
        {
            
        }
    }
}
