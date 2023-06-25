﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_DAL
{
    public class GestionUsuario
    {
        AccesoDatos conexDB = new AccesoDatos();
        private string SP_ActualizarBloqueado = "SP_ActualizarBloqueado";

        public void ActualizarBloqueo(string us, bool bloq)
        {
            try
            {
                conexDB.AbrirConexion();
                SqlCommand cmd = new SqlCommand(SP_ActualizarBloqueado, conexDB.conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", us);
                cmd.Parameters.AddWithValue("@Bloqueado", bloq);
                cmd.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error: " + e.Message);
            }
            finally
            {
                conexDB.CerrarConexion();
            }
        }

    }
}
