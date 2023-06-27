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
            btnAplicar.Enabled = false;
            btnCancelar.Enabled = false;
            LimpiarBox();

            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = false;
                }
            }
        }
        public void LimpiarBox()
        {
            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
        }
        public void ConfigDGV(DataTable dt)
        {
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Columns["Direccion"].Visible = false;
            dgvUsuarios.Columns["Telefono"].Visible = false;
            dgvUsuarios.Columns["Email"].Visible = false;
            dgvUsuarios.Columns["Codigo"].Visible = false;
            dgvUsuarios.Columns["Contraseña"].Visible = false;
            dgvUsuarios.Columns["Intentos"].Visible = false;
            dgvUsuarios.ReadOnly = true;

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
