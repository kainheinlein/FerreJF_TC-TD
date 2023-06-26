using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad_BE;
using Negocio_BLL;
using Servicios;

namespace ProyectoCampo_JuanFer
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        UsuarioBLL usuario;
        GestionBLL gestion;

        #region Funciones
        public void ConfigDefaultForm()
        {
            dgvUsuarios.ReadOnly = true;
            btnAplicar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        public void ConfigDGV(DataTable dt)
        {
            List<string> visibles = new List<string>()
            {
                "Nombre","Apellido","DNI","Usuario","Direccion","Telefono","Email","Activo","Bloqueado"
            };

            // Crea un nuevo DataTable con las columnas seleccionadas
            DataTable tf = new DataTable();

            foreach (string columnaMostrar in visibles)
            {
                if (dt.Columns.Contains(columnaMostrar))
                {
                    tf.Columns.Add(columnaMostrar, dt.Columns[columnaMostrar].DataType);
                }
            }
            // Copia los datos al nuevo DataTable
            foreach (DataRow sourceRow in dt.Rows)
            {
                DataRow newRow = tf.NewRow();

                foreach (DataColumn column in tf.Columns)
                {
                    newRow[column.ColumnName] = sourceRow[column.ColumnName];
                }
                tf.Rows.Add(newRow);
            }
            //Asignamos fuente al DataGrid
            dgvUsuarios.DataSource = tf;
        }
        #endregion

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            gestion = new GestionBLL();
            ConfigDGV(gestion.ObtenerUsuarios());
            ConfigDefaultForm();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
