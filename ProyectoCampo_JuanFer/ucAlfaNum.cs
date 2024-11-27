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
    public partial class ucAlfaNum : UserControl
    {
        public ucAlfaNum()
        {
            InitializeComponent();
        }

        private static string patron = @"^[A-Za-z0-9\s]+$";

        private bool _ok;

        public bool ok
        {
            get { return _ok; }
            set { _ok = value; }
        }

        private string _texto;

        public string texto
        {
            get { return _texto; }
            set { _texto = value; }
        }

        private void ucUsuario_Load(object sender, EventArgs e)
        {
            txtTexto.Clear();
            ptxtTexto.BackColor = Color.DimGray;
            ok = false;
            texto = "";
        }

        private void txtTexto_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtTexto.Text))
            {
                if(Regex.IsMatch(txtTexto.Text, patron))
                {
                    ok = true;
                    ptxtTexto.BackColor = Color.DimGray;
                    texto = txtTexto.Text;
                }
                else
                {
                    ptxtTexto.BackColor = Color.Red;
                    ok = false;
                }
            }
            else
            {
                ptxtTexto.BackColor = Color.Red;
                ok = false;
            }
        }
    }
}
