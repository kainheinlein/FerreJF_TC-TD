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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoCampo_JuanFer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        UsuarioBLL usuario = new UsuarioBLL();

        #region Funciones
        public void IniciarEnabled()
        {
            if (txtUsuario.Text != "" & txtContra.Text != "")
            {
                btnIniciar.Enabled = true;
            }
            else
            {
                btnIniciar.Enabled = false;
            }
        }

        #endregion

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            IniciarEnabled();
            lblError.Text = "";
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            IniciarEnabled();
            lblError.Text = "";
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        //btn Iniciar al presion enter en campo Contraseña
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnIniciar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la aplicacion?","Atencion",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else txtUsuario.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            UsuarioBE user;
            string us = txtUsuario.Text;
            string psw = txtContra.Text;
            string patron = "^[A-Za-z0-9]+$";
            bool okus = Regex.IsMatch(us, patron);
            bool okpsw = Regex.IsMatch(psw, patron);

            if (!okus || !okpsw)//Validacion caracteres
            {
                MessageBox.Show("Los datos ingresados no cumplen con el formato requerido.","Datos Invalidos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtUsuario.Clear();
                txtContra.Clear();
                txtUsuario.Focus();
            }
            else
            {
                try
                {
                    user = new UsuarioBE();
                    user.user = us;
                    user.pass = psw;

                    int authOK = usuario.Login(user);
                    if (authOK == 1)
                    {
                        frmMenu frm = new frmMenu();
                        frm.Show();
                        this.Hide();

                        frm.FormClosing += frm_closing;
                    }
                    else
                    {
                        txtContra.Text = "";
                        txtUsuario.Text = "";
                        txtUsuario.Focus();

                        //Mensaje de label de Error
                        switch (authOK)
                        {
                            case 0:
                                lblError.Text = "El usuario ingresado no existe";
                                break;
                            case 2:
                                lblError.Text = "El usuario se encuentra bloqueado. Contacte al administrador";
                                break;
                            case 3:
                                lblError.Text = "La contraseña ingresada es incorrecta";
                                break;
                            case 4:
                                MessageBox.Show($"El usuario -->{us}<-- no esta disponible. Contacte al administrador.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 5:
                                MessageBox.Show("Cantidad de intentos superado, se bloqueo el usuario. Cerrando la aplicacion.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                                break;
                            case 6:
                                MessageBox.Show($"El usuario -->{us}<-- ya tiene la sesion iniciada.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                frmMenu frm = new frmMenu();
                                frm.Show();
                                this.Hide();

                                frm.FormClosing += frm_closing;
                                break;
                            case 7:
                                if (MessageBox.Show("Ya existe una sesion iniciada, desea finalizarla?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    usuario.Logout();
                                    MessageBox.Show("Sesion cerrada correctamente. Intente nuevamente con su usuario", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else { MessageBox.Show("Intente nuevamente con el usuario actualmente en uso. Si no es el suyo por favor cierre la sesion", " ", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
                                break;
                        }
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error de comunicacion con la Base de Datos: " + ex.Message);
                }
            }
        }

        private void lblSinConexion_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void lblSinConexion_MouseHover(object sender, EventArgs e)
        {
            //lblSinConexion.Cursor = Cursors.Hand;

            var font = ((Label)sender).Font;

            ((Label)sender).Font = new Font(font,FontStyle.Bold);

            font.Dispose();
        }

        private void lblSinConexion_MouseLeave(object sender, EventArgs e)
        {
            var font = ((Label)sender).Font;

            ((Label)sender).Font = new Font(font, FontStyle.Regular);

            font.Dispose();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtContra.Text = "";
            txtUsuario.Text = "";
            this.Show();
            txtUsuario.Focus();
        }
    }
}
