using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        List<string> roles = new List<string>() { "Cajero", "Vendedor", "Administrador" };

        #region Funciones

        private void ConfigDefaultForm()
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
        private void HabilitarCampos()
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
        private void LimpiarDatos()
        {
            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                if (control is Panel panel)
                {
                    panel.BackColor = Color.DimGray;
                }
            }
            cmbRol.SelectedItem = null;
            chkBloqueado.Checked = false;
            txtDoc.Focus();
        }
        /*private void ConfigDGV(DataTable dt)
        {
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Columns["Direccion"].Visible = false;
            dgvUsuarios.Columns["Telefono"].Visible = false;
            dgvUsuarios.Columns["Email"].Visible = false;
            dgvUsuarios.Columns["Codigo"].Visible = false;
            dgvUsuarios.Columns["Contraseña"].Visible = false;
            dgvUsuarios.ReadOnly = true;

        }*/
        private void CargaUsuario()
        {
            bool okCampos = ValCampos();

            if (!okCampos)//Validacion caracteres
            {
                LimpiarDatos();
                txtMensaje.Text = "Los datos ingresados no cumplen con el formato requerido, " +
                    "ingrese los datos sin espacios ni caracteres especiales";
            }
            else
            {
                auxUsuario = new UsuarioBE();
                auxUsuario.dni = Convert.ToInt32(txtDoc.Text);
                auxUsuario.nomb = txtNom.Text;
                auxUsuario.ape = txtApe.Text;
                auxUsuario.rol = cmbRol.SelectedValue.ToString();
                auxUsuario.user = txtUsu.Text;
                auxUsuario.pass = Encriptador.EncriptarIrrev(txtPass.Text);
                auxUsuario.bloq = chkActivo.Checked;
                auxUsuario.estado = chkActivo.Checked;
                auxUsuario.dir = txtDir.Text;
                auxUsuario.tel = Convert.ToInt32(txtTel.Text);
                auxUsuario.email = txtMail.Text;
                txtMensaje.Text = "CargaUsuario OK";
            }

        }
        private void GuardarEnabled()
        {
            if (txtNom.Text != "" & txtApe.Text != "" & txtDoc.Text != ""
                    & txtUsu.Text != "" & txtPass.Text != "" & cmbRol.SelectedValue != null)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }
        #endregion

        #region ValidacionCampos
        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            GuardarEnabled();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            GuardarEnabled();
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            GuardarEnabled();
        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            GuardarEnabled();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            GuardarEnabled();
        }

        private void cmbRol_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            GuardarEnabled();
        }

        private bool ValCampos()
        {
            bool okCampos = false;
            string errorMessage = "";
            string patronT = "/^[A-Za-z]+$/g";
            string patronD = "/^[A-Za-z0-9]+$/g";
            string patronN = "^[0-9]+$";
            string patronS = "^[A-Za-z0-9]+$";
            string patronM = @"/^[^\s@]+@[^\s@]+\.[^\s@]+$/";
            bool txtOK,numOk,sensOK,mailOK = true;
            foreach(TextBox t in gbDatos.Controls)
            {
                if(t.Name == "txtNom" || t.Name == "txtApe")
                {
                    int error = 0;
                    if(!Regex.IsMatch(t.Text,patronT))
                    {
                        foreach(Panel p in gbDatos.Controls)
                        {
                            if(p.Name == "p"+t.Name)
                            {
                                p.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            foreach(Control c in camposTxt)
            {
                if(!Regex.IsMatch(c.Text,patronT))
                {
                    ;
                }
            }
            /*for (int i = 0; i < camposTxt.Length; i++)
                //Validacion campos solo texto
                if(Regex.IsMatch(campoTxt[i], patronT))
                {

                }
            foreach(string i in campoTxt)
            {
                bool ok = Regex.IsMatch(i, patronT);
                if (!ok)
                {
                    txtOK = false;
                    break;
                }
            }*/
            return okCampos;
        }
        #endregion
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            //ConfigDGV(gestion.ObtenerUsuarios());
            cmbRol.DataSource = roles;
            cmbRol.SelectedItem = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            auxUsuario = null;
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
                txtPass.Text = fila.Cells["Contraseña"].Value.ToString();
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
            btnDesbloquear.Enabled = false;
            btnCrearUs.Enabled = false;
            btnElimUs.Enabled = false;
            btnModUs.Enabled = false;
            dgvUsuarios.Enabled = false;
            LimpiarDatos();
            HabilitarCampos();
            chkActivo.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfigDefaultForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                int resultado = -1;
                if(ValCampos());
                {
                    CargaUsuario();
                    resultado = gestion.CrearUsuario(auxUsuario);
                }
            }
        }
    }
}