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

        public int cod
        {
            get { return _cod; }
            set { _cod = value; }
        }

        private string _nomb;

        public string nomb
        {
            get { return _nomb; }
            set { _nomb = value; }
        }

        private string _ape;

        public string ape
        {
            get { return _ape; }
            set { _ape = value; }
        }

        private int _dni;

        public int dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private string _user;

        public string user
        {
            get { return _user; }
            set { _user = value; }
        }

        private string _pass;

        public string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        private string _rol;

        public string rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        private string _dir;

        public string dir
        {
            get { return _dir; }
            set { _dir = value; }
        }

        private string _tel;

        public string tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private Boolean _estado;

        public Boolean estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private Boolean _bloq;

        public Boolean bloq
        {
            get { return _bloq; }
            set { _bloq = value; }
        }

        public UsuarioBE(){}

        public UsuarioBE CrearUsuario(string[] datos)
        {
            this.cod = Convert.ToInt32(datos[0]);
            this.dni = Convert.ToInt32(datos[1]);
            this.nomb = datos[2];
            this.ape = datos[3];
            this.user = datos[4];
            this.rol = datos[5];
            this.pass = datos[6];
            this.dir = datos[7];
            this.tel = (datos[8]);
            this.email = datos[9];
            this.estado = Convert.ToBoolean(datos[10]);
            this.bloq = Convert.ToBoolean(datos[11]);
            return this;
        }
    }
}
