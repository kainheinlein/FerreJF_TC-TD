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
            //_conexion.Dispose();//Libera memoria
            //_conexion=null;
            //GC.Collect();
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

        public DataTable LeerTabla (string sp, SqlParameter[] datos)
        {
            try
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

                return dt;
            }
            catch (Exception e) { throw e;}
            finally { CerrarConexion(); }
        }

        public void Escribir(string sp, SqlParameter[] parametros)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Connection = conexion;
                cmd.Parameters.AddRange(parametros);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e) { throw e; }
            finally { CerrarConexion(); }
        }

        public int Consulta(string sp, SqlParameter[] parametros)
        {
            int result;

            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Connection = conexion;
                cmd.Parameters.AddRange(parametros);
                cmd.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                return result = Convert.ToInt32(cmd.Parameters["@Result"].Value);
            }
            catch (Exception e) { throw e; }
            finally { CerrarConexion(); }
        }
    }
}
