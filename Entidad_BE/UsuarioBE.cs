using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_BE
{
    public class UsuarioBE
    {
        private int _cod;
        private string _nomb;
        private string _ape;
        private int _dni;
        private string _user;
        private string _pass;
        private string _rol;
        private string _dir;
        private int _tel;
        private string _email;
        private Boolean _estado;
        private Boolean _bloq;

        public UsuarioBE(){}

        public int cod { get => _cod; set => _cod = value; }
        public string nomb { get => _nomb; set => _nomb = value; }
        public string ape { get => _ape; set => _ape = value; }
        public int dni { get => _dni; set => _dni = value; }
        public string user { get => _user; set => _user = value; }
        public string pass { get => _pass; set => _pass = value; }
        public string dir { get => _dir; set => _dir = value; }
        public int tel { get => _tel; set => _tel = value; }
        public string email { get => _email; set => _email = value; }
        public bool estado { get => _estado; set => _estado = value; }
        public bool bloq { get => _bloq; set => _bloq = value; }
        public string rol { get => _rol; set => _rol = value; }
    }
}
