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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
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
            string us = txtUsuario.Text;
            string psw = txtContra.Text;
            string patron = "^[A-Za-z0-9]+$";
            bool okus = Regex.IsMatch(us, patron);
            bool okpsw = Regex.IsMatch(psw, patron);

            if (!okus || !okpsw)//Validacion caracteres
            {
                MessageBox.Show("El texto ingresado no cumple con el formato requerido.");
                txtUsuario.Clear();
                txtContra.Clear();
                txtUsuario.Focus();
            }
            else
            {
                int authOK = usuario.Login(us, psw);
                if (authOK == 1)
                {
                    usuario.maxIntentos = 3;
                    FrmMenu frm = new FrmMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    txtContra.Text = "";
                    txtUsuario.Focus();

                    //Mensaje de label de Error
                    switch (authOK)
                    {
                        case -1:
                            lblError.Text = "Hubo un error de conexion con la Base de Datos. Contacte al Administrador";
                            break;
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
                            MessageBox.Show("Cantidad de intentos superado, se bloqueo el usuario. Cerrando la aplicacion.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
                            break;
                    }
                }
                //MessageBox.Show("Resultado Login -> " + Convert.ToString(authOK));
            }

        }

        private void lblSinConexion_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }

        private void lblSinConexion_MouseHover(object sender, EventArgs e)
        {
            lblSinConexion.Cursor = Cursors.Hand;

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
    }
}
