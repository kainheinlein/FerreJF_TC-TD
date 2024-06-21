using Entidad_BE;
using Negocio_BLL;
using Servicios;
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

namespace ProyectoCampo_JuanFer
{
    public partial class frmModClave : Form
    {
        public frmModClave()
        {
            InitializeComponent();
        }

        UsuarioBLL usuario = new UsuarioBLL();
        UsuarioBE us = new UsuarioBE();
        int verif = 0;
        string patron = "^[A-Za-z0-9]+$";

        #region Modificadores Formulario
        public void CambiarEnabled()
        {
            if (txtClave.Text != "" & txtClaveRep.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else { btnAceptar.Enabled = false; }
        }

        public void LimpiaClave()
        {
            txtClave.Clear();
            txtClaveRep.Clear();
            txtClave.Focus();
        }

        public void VerificarEnabled()
        {
            if (txtActual.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else { btnLogin.Enabled = false; }
        }

        private void txtActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void txtActual_TextChanged(object sender, EventArgs e)
        {
            VerificarEnabled();
            lblError.Text = "";
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            CambiarEnabled();
            lblError.Text = "";
        }

        private void txtClaveRep_TextChanged(object sender, EventArgs e)
        {
            CambiarEnabled();
            lblError.Text = "";
        }

        private void txtClaveRep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnAceptar_Click(sender, e);
            }
        }

        #endregion

        bool OkText (string text)
        {
            return Regex.IsMatch(text, patron);
        }

        private void frmModClave_Load(object sender, EventArgs e)
        {
            lblInstrucciones.Text = "Introduzca su contraseña actual";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(OkText(txtActual.Text))
            {
                us.pass = txtActual.Text;
                verif = usuario.VerifUsuario(us,0);

                switch (verif)
                {
                    case 0:
                        txtActual.Clear();
                        txtActual.Focus();
                        lblError.Text = $"Contraseña incorrecta, quedan {usuario.maxIntentos.ToString()} intentos";
                        break;
                    case 1:
                        btnLogin.Visible = false;
                        lblActual.Visible = false;
                        txtActual.Visible = false;
                        lblNuevo.Visible = true;
                        txtClave.Visible = true;
                        lblRep.Visible = true;
                        txtClaveRep.Visible = true;
                        btnAceptar.Visible = true;
                        lblInstrucciones.Text = "Introduzca una contraseña distinta a la anterior. Recuerde introducir solo letras y numeros";
                        break;
                    case 2:
                        MessageBox.Show("Cantidad de intentos superados, usuario bloqueado. Contacte al administrador", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usuario.Logout();
                        Application.Exit();
                        break;
                }
            }
            else
            {
                txtActual.Clear();
                lblError.Text = "Formato de contraseña ingresado incorrecto";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (OkText(txtClave.Text) && OkText(txtClaveRep.Text))
            {
                if (txtClave.Text == txtClaveRep.Text)
                {
                    try
                    {
                        us.pass = txtClave.Text;
                        verif = usuario.VerifUsuario(us, 1);

                        if (verif == 1)
                        {
                            LimpiaClave();
                            lblError.Text = "La nueva contraseña debe ser distinta a la anterior";
                        }
                        else
                        {
                            MessageBox.Show("Contraseña cambiada correctamente", "Nueva Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error de comunicacion con la base de datos: " + ex.Message);
                        this.Close();
                    }
                }
                else
                {
                    LimpiaClave();
                    lblError.Text = "Las contraseñas son distintas, vuelva a intentarlo";
                }
            }
            else
            {
                LimpiaClave();
                lblError.Text = "La contraseña no coincide con el formato necesario";
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblInstrucciones_Click(object sender, EventArgs e)
        {

        }
    }
}
