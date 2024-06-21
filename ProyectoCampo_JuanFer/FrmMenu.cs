using Entidad_BE;
using Negocio_BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCampo_JuanFer
{
    public partial class frmMenu : Form
    {
        private frmUsuario frmUsuario;
        private frmCliente frmCliente;
        private frmCarrito frmCarrito;
        public frmMenu()
        {
            InitializeComponent();
        }

        #region Set Formulario
        public void FormConectado()
        {
            UsuarioBE usActual = SessionManager.GetInstance.UsuarioActual();
            lblUsuario.Text = "Usuario: " + usActual.user;
            iniciarSesionToolStripMenuItem.Enabled = false;
            cerrarSesionToolStripMenuItem.Enabled = true;
            tsAdmin.Enabled = true;
            tsReportes.Enabled = true;
            tsGestion.Enabled = true;
            realizarCobroToolStripMenuItem.Enabled = true;
            cambiarClaveToolStripMenuItem.Enabled = true;
        }

        public void FormDesconectado()
        {
            lblUsuario.Text = "Usuario: Sin Conexion";
            iniciarSesionToolStripMenuItem.Enabled = true;
            cerrarSesionToolStripMenuItem.Enabled = false;
            tsAdmin.Enabled = false;
            tsReportes.Enabled = false;
            tsGestion.Enabled = false;
            realizarCobroToolStripMenuItem.Enabled = false;
            cambiarClaveToolStripMenuItem.Enabled = false;
        }

        #endregion
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (SessionManager.GetInstance.logged == true)
            {
                FormConectado();
            }
            else
            {
                FormDesconectado();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la aplicacion?", "Atencion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SessionManager.GetInstance.Logout();
                Application.Exit();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la sesion?", "Atencion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioBLL usuario = new UsuarioBLL(); 
                usuario.Logout();

                frmLogin frm = new frmLogin();
                frm.Show();
                this.Close();
            }
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUsuario == null || frmUsuario.IsDisposed)
            {
                frmUsuario = new frmUsuario()
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
                frmUsuario.Show();
            }
            else
            {
                frmUsuario.BringToFront();
            }
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModClave frmClave = new frmModClave();
            frmClave.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCliente == null || frmCliente.IsDisposed)
            {
                frmCliente = new frmCliente()
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
                frmCliente.Show();
            }
            else
            {
                frmCliente.BringToFront();
            }
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmCarrito == null || frmCarrito.IsDisposed)
            {
                frmCarrito = new frmCarrito()
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
                frmCarrito.Show();
            }
            else
            {
                frmCarrito.BringToFront();
            }
        }
    }
}
