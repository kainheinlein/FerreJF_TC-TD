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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Acceso_DAL
{
    public class AccesoDatos
    {
        private SqlConnection _conexion;
        private readonly string cadenaSQL = @"Data Source=KAIN-NB\SQLEXPRESS;Initial Catalog=FerreDB;Integrated Security=True";

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

        public DataTable Leer (string sp, SqlParameter[] datos)
        {
            AbrirConexion();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = new SqlCommand();
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            ad.SelectCommand.CommandText = sp;
            if (datos != null)
            {
                ad.SelectCommand.Parameters.AddRange(datos);
            }
            ad.SelectCommand.Connection = conexion;
            ad.Fill(dt);
            CerrarConexion();

            return dt;
        }
    }
}
