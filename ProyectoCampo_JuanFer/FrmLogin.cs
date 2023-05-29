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

        #region Funciones
        public void IniciarEnabled()
        {
            if (txtUsuario.Text == "" & txtContra.Text =="")
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
            }
        }

        #endregion

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            IniciarEnabled();
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            IniciarEnabled();
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
            UsuarioBLL usuario = new UsuarioBLL();
            int authOK = usuario.Login(txtUsuario.Text, txtContra.Text);
            if (authOK == 1) 
            {
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



            MessageBox.Show("Resultado Login -> " + Convert.ToString(authOK));
            //}
            //else MessageBox.Show("No pasa por objeto");
        }
    }
}
