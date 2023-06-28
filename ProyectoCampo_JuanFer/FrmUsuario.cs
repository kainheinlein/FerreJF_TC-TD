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
        UsuarioBE auxUsuario;
        GestionBLL gestion = new GestionBLL();
        List<string> roles = new List<string>() {"Cajero","Vendedor","Administrador"};

        #region Funciones

        public void ConfigDefaultForm()
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            cmbRol.Enabled = false;
            btnCrearUs.Enabled = true;
            btnModUs.Enabled = true;
            btnElimUs.Enabled = true;
            btnDesbloquear.Enabled = true;
            dgvUsuarios.Enabled = true;
            LimpiarDatos();

            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = false;
                }
            }
        }
        public void HabilitarCampos()
        {
            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = true;
                }
                cmbRol.Enabled = true;
            }
        }
        public void LimpiarDatos()
        {
            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
            cmbRol.SelectedItem = null;
            chkActivo.Checked = false;
            chkBloqueado.Checked = false;
        }
        public void ConfigDGV(DataTable dt)
        {
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Columns["Direccion"].Visible = false;
            dgvUsuarios.Columns["Telefono"].Visible = false;
            dgvUsuarios.Columns["Email"].Visible = false;
            dgvUsuarios.Columns["Codigo"].Visible = false;
            dgvUsuarios.Columns["Contraseña"].Visible = false;
            dgvUsuarios.ReadOnly = true;

        }
        private void CargaUsuario()
        {

        }


        #endregion

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ConfigDGV(gestion.ObtenerUsuarios());
            cmbRol.DataSource = roles;
            cmbRol.SelectedItem = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        //Carga de datos de fila seleccionada a textbox
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                txtDoc.Text = fila.Cells["DNI"].Value.ToString();
                txtNom.Text = fila.Cells["Nombre"].Value.ToString();
                txtApe.Text = fila.Cells["Apellido"].Value.ToString();
                cmbRol.SelectedIndex = cmbRol.Items.IndexOf(Convert.ToString(fila.Cells["Rol"].Value));
                txtUsu.Text = fila.Cells["Usuario"].Value.ToString();
                txtDir.Text = fila.Cells["Direccion"].Value.ToString();
                txtTel.Text = fila.Cells["Telefono"].Value.ToString();
                txtMail.Text = fila.Cells["Email"].Value.ToString();
                if (Convert.ToBoolean(fila.Cells["Activo"].Value) == true)
                {
                    chkActivo.Checked = true;
                }
                if (Convert.ToBoolean(fila.Cells["Bloqueado"].Value) == true)
                {
                    chkBloqueado.Checked = true;
                }
            }
        }

        private void btnCrearUs_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnDesbloquear.Enabled = false;
            btnCrearUs.Enabled = false;
            btnElimUs.Enabled = false;
            btnModUs.Enabled = false;
            dgvUsuarios.Enabled = false;
            LimpiarDatos();
            HabilitarCampos();
            chkActivo.Checked = true;
            txtDoc.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfigDefaultForm();
        }
    }
}
