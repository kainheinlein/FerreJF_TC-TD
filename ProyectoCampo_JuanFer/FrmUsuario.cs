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

        private void ConfigDGV(DataTable dt)
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
            if (ValCampos())//Validacion caracteres
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
                if(txtDir.Text != string.Empty) { auxUsuario.dir = txtDir.Text; }
                if(txtTel.Text != string.Empty) { auxUsuario.tel = Convert.ToInt32(txtTel.Text); }
                if(txtMail.Text != string.Empty) { auxUsuario.email = txtMail.Text; }
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

        private void CampoError(string campo)
        //Marcar en rojo los campos con validacion no ok
        {
            foreach (Control p in gbDatos.Controls)
            {
                if (p is Panel & (p.Name == "p" + campo))
                {
                    p.BackColor = Color.Red;
                    break;
                }
            }
        }
        #endregion

        #region ValidacionCampos
        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            ptxtDoc.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            ptxtNom.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            ptxtApe.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            ptxtUsu.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            ptxtPass.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            ptxtDir.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            ptxtTel.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            ptxtMail.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void cmbRol_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            GuardarEnabled();
        }

        private bool ValCampos()
        {
            string patronT = @"^[a-zA-Z\s]+$";
            string patronD = @"^[A-Za-z0-9\s]+$";
            string patronN = "^[0-9]+$";
            string patronS = "^[A-Za-z0-9]+$";
            string patronM = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
            bool txtOK,numOK,sensOK,dirOK,mailOK;
            txtOK = numOK = sensOK = dirOK = mailOK = true;

            foreach(Control t in gbDatos.Controls)
            {   
                if(t is TextBox)
                {
                    //Validacion Nombre y Apellido
                    if (t.Name == "txtNom" || t.Name == "txtApe")
                    {
                        if (!Regex.IsMatch(t.Text, patronT))
                        {
                            CampoError(t.Name);
                            txtOK = false;
                        }
                    }
                    else
                    {
                        //Validacion Direccion
                        if (t.Name == "txtDir")
                        {
                            if (!Regex.IsMatch(t.Text, patronD) & t.Text != string.Empty)
                            {
                                CampoError(t.Name);
                                dirOK = false;
                            }
                        }
                        else
                        {
                            //Validacion User y Pass
                            if (t.Name == "txtUsu" || t.Name == "txtPass")
                            {
                                if (!Regex.IsMatch(t.Text, patronS))
                                {
                                    CampoError (t.Name);
                                    sensOK = false;
                                }
                            }
                            else
                            {
                                //Validacion DNI y Telefono
                                if ((t.Name == "txtTel" & t.Text != string.Empty) || t.Name == "txtDoc")
                                {   
                                    if (!Regex.IsMatch(t.Text, patronN))
                                    {
                                        CampoError(t.Name);
                                        numOK = false;
                                    }
                                }
                                else
                                {
                                    //Validacion Mail
                                    if (t.Name == "txtMail" & t.Text != string.Empty)
                                    {
                                        if (!Regex.IsMatch(t.Text, patronM))
                                        {
                                            CampoError(t.Name);
                                            mailOK = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #region Texto de error en Campo Mensajes
            if (!txtOK)
            {
                txtMensaje.Text = txtMensaje.Text + "Campos Nombre y/o Apellido contienen caracteres no validos." +
                    "Ingrese solo letras por favor." + Environment.NewLine;
            }

            if (!numOK)
            {
                txtMensaje.Text = txtMensaje.Text + "Campos DNI y/o Telefono contienen caracteres no validos." +
                    "Ingrese solo numeros por favor." + Environment.NewLine;
            }

            if (!dirOK)
            {
                txtMensaje.Text = txtMensaje.Text + "Campo Direccion contiene caracteres no validos." +
                    "Ingrese solo letras y numeros por favor." + Environment.NewLine;
            }

            if (!sensOK)
            {
                txtMensaje.Text = txtMensaje.Text + "Campos Usuario y/o Contraseña contienen caracteres no validos." +
                    "No se permiten espacios ni caracteres especiales." + Environment.NewLine;
            }

            if (!mailOK)
            {
                txtMensaje.Text = txtMensaje.Text + "Campo eMail contiene caracteres no validos." +
                    "Respete el formato xxxx@xxx.xxx, sin espacios ni caracteres especiales." + Environment.NewLine;
            }
            #endregion

            if(!txtOK || !sensOK || !dirOK || !numOK || !mailOK)
            {
                txtDoc.Focus();
                return false;
            }
            else { return true; }
        }
        #endregion
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigDGV(gestion.ObtenerUsuarios());
                cmbRol.DataSource = roles;
                cmbRol.SelectedItem = null;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                if(ValCampos())
                {
                    CargaUsuario();
                    resultado = gestion.CrearUsuario(auxUsuario);
                }
            }
        }

        private void btnModUs_Click(object sender, EventArgs e)
        {

        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {

        }
    }
}