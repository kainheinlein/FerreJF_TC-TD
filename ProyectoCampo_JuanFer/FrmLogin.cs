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
using System.Threading.Tasks;
using System.Windows.Forms;

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

            /*if (txtUsuario.Text == "" & txtContra.Text =="")
            {
                btnIniciar.Enabled = false;
            }
            else if (txtUsuario.Text != "" & txtContra.Text == "")
            {
                btnIniciar.Enabled = false;
            }
            else if (txtUsuario.Text == "" & txtContra.Text != "")
            {
                btnIniciar.Enabled = false;
            }
            else
            {
                btnIniciar.Enabled = true;
            }*/
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
            int authOK = usuario.Login(txtUsuario.Text, txtContra.Text);
            if (authOK == 1) 
            {
                usuario.maxIntentos = 3;
                //Buscar entre formularios abiertos, crear nuevo si no existe, mandar al frente si existe
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMenu);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                else
                {
                    frm = new FrmMenu();
                    frm.Show();
                    this.Hide();
                }
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
                    case  0: 
                        lblError.Text = "El usuario ingresado no existe";
                        break;
                    case 2: 
                        lblError.Text = "El usuario se encuentra bloqueado. Contacte al administrador";
                        break;
                    case 3: 
                        lblError.Text = "La contraseña ingresada es incorrecta";
                        break;
                    case 4:
                        MessageBox.Show("Se alcanzo la cantidad maxima de intentos. Cerrando la aplicacion.","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        Application.Exit();
                        break;
                }
            }
            MessageBox.Show("Resultado Login -> " + Convert.ToString(authOK));
        }
    }
}
