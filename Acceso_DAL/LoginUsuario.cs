using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_DAL
{
    public class LoginUsuario
    {
        AccesoDatos conexDB = new AccesoDatos();
        private string SP_Login = "SP_Login";
        int resultado = -1;

        public int Login(string us, string pw)
        {
            try 
            {
                conexDB.AbrirConexion();
                SqlCommand cmd = new SqlCommand(SP_Login, conexDB.conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"user", us);
                cmd.Parameters.AddWithValue(@"pass", pw);
                cmd.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                resultado = Convert.ToInt32(cmd.Parameters["@Result"].Value);

                return resultado;
            }
            catch (Exception e) 
            {
                MessageBox.Show("Ha ocurrido un error: " + e.Message);
            }
            finally
            {
                conexDB.CerrarConexion();
            }
            return resultado ;
        }
    }
}
