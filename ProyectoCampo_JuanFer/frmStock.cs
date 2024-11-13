using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad_BE;
using Negocio_BLL;
using static System.Collections.Specialized.BitVector32;

namespace ProyectoCampo_JuanFer
{
    public partial class frmStock : Form
    {
        NegocioBLL negocio = new NegocioBLL();
        List<string> tipo = new List<string>() { "Codigo", "Proveedor", "Categoria", "Palabra" };

        public frmStock()
        {
            InitializeComponent();
        }

        private void ConfigDefaultForm()
        {
            HabilitarBtn(btnCarrito, false);
            HabilitarBtn(btnBuscar, false);
            HabilitarBtn(btnAgregar, false);
            HabilitarBtn(btnQuitar, false);
            txtBuscar.Enabled = false;
            txtCant.Enabled = false;

            foreach (Control c in pProductos.Controls)
            {
                if (c is Button btn)
                {
                    if (btn.Enabled) { btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold); btn.ForeColor = Color.Black; }
                    else { btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Regular); }
                    c.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
        }

        private void ConfigDGV(List<ProductoBE> prod)
        {
            dgvInventario.DataSource = prod;
            dgvInventario.ReadOnly = true;
        }
        private void ActualizarInv()
        {
            dgvInventario.DataSource = negocio.ObtenerProductos();
            ConfigDefaultForm();
        }

        private void HabilitarBtn(Button btn, bool tipo)
        {
            if (tipo)
            {
                btn.Enabled = tipo;
                btn.Font = new Font(btn.Font.Name, btnCarrito.Font.Size, FontStyle.Bold);
                btn.ForeColor = Color.Black;
            }
            else
            {
                btn.Font = new Font(btn.Font.Name, btnCarrito.Font.Size, FontStyle.Regular);
                btn.Enabled = tipo;
            }
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigDGV(negocio.ObtenerProductos());
                cmbBuscar.DataSource = tipo;
                cmbBuscar.SelectedItem = null;
                ConfigDefaultForm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            btnCarrito.Enabled = true; //Prueba
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCant.Enabled = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != null && cmbBuscar.SelectedItem != null) { HabilitarBtn(btnBuscar,true); }
        }

        private void cmbBuscar_ValueMemberChanged(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
        }
    }
}
