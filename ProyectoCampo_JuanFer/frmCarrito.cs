﻿using System;
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
    public partial class frmCarrito : Form
    {
        public frmCarrito()
        {
            InitializeComponent();
        }
        public frmCarrito(DataTable dt)
        {

        }

        private void frmCarrito_Load(object sender, EventArgs e)
        {
            frmMenu.formActivo = this;
        }


    }
}
