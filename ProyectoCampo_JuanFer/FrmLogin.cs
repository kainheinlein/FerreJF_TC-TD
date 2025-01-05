using Entidad_BE;
using Negocio_BLL;
using Servicios;
using System;
using System.Diagnostics;
using System.ServiceProcess;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        UsuarioBLL usuario = new UsuarioBLL();

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContra.boton = this.btnIniciar;
            try
            {
                if (scBase.Status == ServiceControllerStatus.Stopped)
                {
                    scBase.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Occurio un error: " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblError.Text = "";
        }

        private void txtContra_Load(object sender, EventArgs e)
        {
            txtContra.Hide(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la aplicacion?","Atencion",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else txtUsuario.Enfocar();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            UsuarioBE user;

            if (!txtUsuario.ok || !txtContra.ok)
            {
                MessageBox.Show("Los datos ingresados no cumplen con el formato requerido.", "Datos Invalidos", MessageBoxButtons.OK,                       MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    user = new UsuarioBE();
                    user.user = txtUsuario.texto;
                    user.pass = txtContra.texto;

                    int authOK = usuario.Login(user);
                    if (authOK == 1)
                    {
                        frmMenu frm = new frmMenu();
                        frm.Show();
                        this.Hide();

                        frm.FormClosing += frm_closing;
                    }
                    else
                    {
                        //Mensaje de label de Error
                        switch (authOK)
                        {
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
                                MessageBox.Show($"El usuario -->{user.user}<-- no esta disponible. Contacte al administrador.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 5:
                                MessageBox.Show("Cantidad de intentos superado, se bloqueo el usuario. Cerrando la aplicacion.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                                break;
                            case 6:
                                MessageBox.Show($"El usuario -->{user.user}<-- ya tiene la sesion iniciada.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                frmMenu frm = new frmMenu();
                                frm.Show();
                                this.Hide();

                                frm.FormClosing += frm_closing;
                                break;
                            case 7:
                                if (MessageBox.Show("Ya existe una sesion iniciada, desea finalizarla?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    usuario.Logout();
                                    MessageBox.Show("Sesion cerrada correctamente. Intente nuevamente con su usuario", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else { MessageBox.Show("Intente nuevamente con el usuario actualmente en uso. Si no es el suyo por favor cierre la sesion", " ", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
                                break;
                        }
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error de comunicacion con la Base de Datos: " + ex.Message);
                }
            }
            txtUsuario.Limpiar();
            txtContra.Limpiar();
            txtUsuario.Enfocar();
        }

        private void lblSinConexion_Click(object sender, EventArgs e)
        {
            usuario.Logout();
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void lblSinConexion_MouseHover(object sender, EventArgs e)
        {
            var font = ((Label)sender).Font;

            ((Label)sender).Font = new Font(font, FontStyle.Bold);

            font.Dispose();
        }

        private void lblSinConexion_MouseLeave(object sender, EventArgs e)
        {
            var font = ((Label)sender).Font;

            ((Label)sender).Font = new Font(font, FontStyle.Regular);

            font.Dispose();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtContra.Limpiar();
            txtUsuario.Limpiar();
            this.Show();
            txtUsuario.Enfocar();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}
