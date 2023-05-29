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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        //FrmLogin form = null;

        private void crearModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsu = new FrmUsuario();
            frmUsu.MdiParent = this;
            frmUsu.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Buscar entre formularios abiertos, crear nuevo si no existe, mandar al frente si existe
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new FrmLogin();
                frm.Show(this);
            }
        }
    }
}
