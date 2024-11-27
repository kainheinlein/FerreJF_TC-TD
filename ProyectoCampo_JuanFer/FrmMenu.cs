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
        public static ToolStripMenuItem opcActivo = null;
        public static Form formActivo = null;
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
            cerrarSesionToolStripMenuItem.Visible = false;
            tsAdmin.Visible = false;
            tsReportes.Visible = false;
            tsGestion.Visible = false;
            realizarCobroToolStripMenuItem.Visible = false;
            cambiarClaveToolStripMenuItem.Visible = false;
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

        private void OpenForm(ToolStripMenuItem opc, Form frm)
        {
            if(opcActivo != null)
            {
                opcActivo.BackColor = Color.WhiteSmoke;
            }
            opc.BackColor = Color.Gainsboro;
            opcActivo = opc;

            if(formActivo != null) { formActivo.Close(); }
            formActivo = frm;
            frm.MdiParent = this;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            frm.Show();
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
            OpenForm(tsAdmin, new frmUsuario());
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
            OpenForm(tsGestion, new frmCliente());

        }

        private void CarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(tsVentas, new frmStock());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
