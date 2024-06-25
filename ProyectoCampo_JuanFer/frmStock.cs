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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            frmCarrito frmCarrito = new frmCarrito
            {
                MdiParent = ActiveForm,
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            this.Close();
            frmCarrito.Show();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            btnCarrito.Enabled = true;
        }
    }
}
