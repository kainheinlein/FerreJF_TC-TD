using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entidad_BE;
using System.Windows.Forms;

namespace Acceso_DAL
{
    public class AccesoDatos
    {
        private SqlConnection _conexion;
        private readonly string cadenaSQL = @"Data Source=KAIN-MR\SQLEXPRESS;Initial Catalog=FerreDB;Integrated Security=True";

        public SqlConnection conexion { get => _conexion; }

        public void AbrirConexion()
        {
            _conexion = new SqlConnection(cadenaSQL);
            _conexion.Open();
        }

        public void CerrarConexion()
        {
            _conexion.Close();
            _conexion.Dispose();//Libera memoria
            _conexion=null;
            GC.Collect();
        }

        public bool VerificarConexion()
        {
            AbrirConexion();
            if (_conexion.State == ConnectionState.Open)
            {
                CerrarConexion();
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}
