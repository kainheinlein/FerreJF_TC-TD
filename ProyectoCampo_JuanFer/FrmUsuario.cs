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
using Entidad_BE;
using Negocio_BLL;

namespace ProyectoCampo_JuanFer
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        UsuarioBE auxUsuario;
        NegocioBLL gestion = new NegocioBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        int varMod = 0; //Indica si la modificacion esta activa
        List<string> roles = new List<string>() { "Cajero", "Vendedor", "Administrador" };

        #region Funciones

        private void ConfigDefaultForm()
        {
            HabilitarBtn(btnGuardar, false);
            HabilitarBtn(btnCancelar, false);
            cmbRol.Enabled = false;
            HabilitarBtn(btnCrearUs, true);
            HabilitarBtn(btnModUs, false);
            HabilitarBtn(btnElimUs, false);
            HabilitarBtn(btnDesbloquear, false);
            dgvUsuarios.Enabled = true;
            chkActivo.Enabled = false;
            varMod = 0;
            foreach(Control c in pUsuario.Controls)
            {
                if (c is Button btn)
                {
                    if (btn.Enabled) { btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold); btn.ForeColor = Color.Black; }
                    else { btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Regular); }
                    c.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
            LimpiarDatos();

            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = false;
                }
            }
        }

        private void HabilitarBtn(Button btn, bool tipo)
        {
            if(tipo)
            {
                btn.Enabled = tipo;
                btn.Font = new Font(btn.Font.Name, btnGuardar.Font.Size, FontStyle.Bold);
                btn.ForeColor = Color.Black;
            }
            else
            {
                btn.Font = new Font(btn.Font.Name, btnGuardar.Font.Size, FontStyle.Regular);
                btn.Enabled = tipo;
            }
        }

        private Button ultimoBoton = null;

        private void ClickBoton(object sender, EventArgs e)
        {
            if(ultimoBoton != null)
            {
                ultimoBoton.BackColor = Color.FromArgb(255, 192, 192);
            }
            
            if((sender as Button).Text != "Cancelar")
            {
                (sender as Button).BackColor = Color.LightCoral;
            }
            ultimoBoton = (sender as Button);
        }

        private void HabilitarCampos()
        {
            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = true;
                }
                cmbRol.Enabled = true;
            }
        }

        private void LimpiarDatos()
        {
            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                if (control is Panel panel)
                {
                    panel.BackColor = Color.DimGray;
                }
            }
            cmbRol.SelectedItem = null;
            chkBloqueado.Checked = false;
            chkActivo.Checked = false;
            txtDoc.Focus();
        }

        private void ConfigDGV(List<UsuarioBE> usuarios)
        {
            dgvUsuarios.DataSource = usuarios;
            dgvUsuarios.Columns["dir"].Visible = false;
            dgvUsuarios.Columns["tel"].Visible = false;
            dgvUsuarios.Columns["email"].Visible = false;
            dgvUsuarios.Columns["cod"].Visible = false;
            dgvUsuarios.Columns["pass"].Visible = false;
            dgvUsuarios.Columns[1].HeaderText = "DNI";
            dgvUsuarios.Columns[2].HeaderText = "Nombre";
            dgvUsuarios.Columns[3].HeaderText = "Apellido";
            dgvUsuarios.Columns[4].HeaderText = "Usuario";
            dgvUsuarios.Columns[5].HeaderText = "Rol";
            dgvUsuarios.Columns[10].HeaderText = "Activo";
            dgvUsuarios.Columns[11].HeaderText = "Bloqueado";
            dgvUsuarios.ReadOnly = true;
        }

        private void ActualizarDGV()
        {
            dgvUsuarios.DataSource = gestion.ListarUsuarios();
            ConfigDefaultForm();
        }

        private UsuarioBE CargaUsuario()
        {
            if (ValCampos())//Validacion caracteres
            {
                auxUsuario = new UsuarioBE();
                auxUsuario.dni = Convert.ToInt32(txtDoc.Text);
                auxUsuario.nomb = txtNom.Text;
                auxUsuario.ape = txtApe.Text;
                auxUsuario.rol = cmbRol.SelectedValue.ToString();
                auxUsuario.user = txtUsu.Text;
                auxUsuario.estado = chkActivo.Checked;
                auxUsuario.bloq = chkBloqueado.Checked;
                if (txtDir.Text == string.Empty) { auxUsuario.dir = " "; }
                else { auxUsuario.dir = txtDir.Text; }
                if (txtTel.Text == string.Empty) { auxUsuario.tel = " "; }
                else { auxUsuario.tel = txtTel.Text; }
                if (txtMail.Text == string.Empty) { auxUsuario.email = " "; }
                else { auxUsuario.email = txtMail.Text; }

                return auxUsuario;
            }
            return null;
        }

        private void GuardarEnabled()
        {
            if (txtNom.Text != "" & txtApe.Text != "" & txtDoc.Text != ""
                    & txtUsu.Text != "" & cmbRol.SelectedValue != null)
            {
                HabilitarBtn(btnGuardar,true);
            }
            else
            {
                HabilitarBtn(btnGuardar,false);
            }
        }

        private void CampoError(string campo)
        //Marcar en rojo los campos con validacion no ok
        {
            foreach (Control p in gbDatos.Controls)
            {
                if (p is Panel & (p.Name == "p" + campo))
                {
                    p.BackColor = Color.Red;
                    break;
                }
            }
        }

        private UsuarioBE ExtraerDatos (DataGridViewRow fila)
        {
            string[] datos = new string [fila.Cells.Count];

            for(int i = 0; i < fila.Cells.Count;i++)
            {
                datos[i] = fila.Cells[i].Value.ToString();
            }
            auxUsuario = new UsuarioBE();
            return auxUsuario.CrearUsuario(datos);
        }

        private void LlenarMensaje(string linea)
        {
            txtMensaje.Text = linea + Environment.NewLine + Environment.NewLine + txtMensaje.Text;
        }

        #endregion

        #region ValidacionCampos
        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            ptxtDoc.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            ptxtNom.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {
            ptxtApe.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {
            ptxtUsu.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {
            ptxtDir.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            ptxtTel.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            ptxtMail.BackColor = Color.DimGray;
            GuardarEnabled();
        }

        private void cmbRol_SelectedValueChanged(object sender, EventArgs e)
        {
            GuardarEnabled();
        }

        private bool ValCampos()
        {
            string patronT = @"^[a-zA-Z\s]+$";
            string patronD = @"^[A-Za-z0-9\s]+$";
            string patronN = "^[0-9]+$";
            string patronS = "^[A-Za-z0-9]+$";
            string patronM = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
            bool txtOK, numOK, sensOK, dirOK, mailOK;
            txtOK = numOK = sensOK = dirOK = mailOK = true;

            foreach (Control t in gbDatos.Controls)
            {
                if (t is TextBox)
                {
                    //Validacion Nombre y Apellido
                    if (t.Name == "txtNom" || t.Name == "txtApe")
                    {
                        if (!Regex.IsMatch(t.Text, patronT))
                        {
                            CampoError(t.Name);
                            txtOK = false;
                        }
                    }
                    else
                    {
                        //Validacion Direccion
                        if (t.Name == "txtDir")
                        {
                            if (!Regex.IsMatch(t.Text, patronD) & t.Text != string.Empty)
                            {
                                CampoError(t.Name);
                                dirOK = false;
                            }
                        }
                        else
                        {
                            //Validacion User y Pass
                            if (t.Name == "txtUsu")
                            {
                                if (!Regex.IsMatch(t.Text, patronS))
                                {
                                    CampoError(t.Name);
                                    sensOK = false;
                                }
                            }
                            else
                            {
                                //Validacion DNI y Telefono
                                if ((t.Name == "txtTel" & t.Text != string.Empty) || t.Name == "txtDoc")
                                {
                                    if (!Regex.IsMatch(t.Text, patronN))
                                    {
                                        CampoError(t.Name);
                                        numOK = false;
                                    }
                                }
                                else
                                {
                                    //Validacion Mail
                                    if (t.Name == "txtMail" & t.Text != string.Empty)
                                    {
                                        if (!Regex.IsMatch(t.Text, patronM))
                                        {
                                            CampoError(t.Name);
                                            mailOK = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #region Texto de error en Campo Mensajes
            if (!txtOK)
            {
                LlenarMensaje("Campos Nombre y/o Apellido contienen caracteres no validos." +
                    "Ingrese solo letras por favor.");
            }

            if (!numOK)
            {
                LlenarMensaje("Campos DNI y/o Telefono contienen caracteres no validos." +
                    "Ingrese solo numeros por favor.");
            }

            if (!dirOK)
            {
                LlenarMensaje("Campo Direccion contiene caracteres no validos." +
                    "Ingrese solo letras y numeros por favor.");
            }

            if (!sensOK)
            {
                LlenarMensaje("Campo Usuario contiene caracteres no validos." +
                    "No se permiten espacios ni caracteres especiales.");
            }

            if (!mailOK)
            {
                LlenarMensaje("Campo eMail contiene caracteres no validos." +
                    "Respete el formato xxxx@xxx.xxx, sin espacios ni caracteres especiales.");
            }
            #endregion

            if (!txtOK || !sensOK || !dirOK || !numOK || !mailOK)
            {
                txtDoc.Focus();
                return false;
            }
            else { return true; }
        }
        #endregion
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigDGV(gestion.ListarUsuarios());
                cmbRol.DataSource = roles;
                ConfigDefaultForm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            auxUsuario = null;
            Control control = btnSalir.Parent;
            frmMenu.opcActivo.BackColor = Color.WhiteSmoke;
            this.Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        //Carga de datos de fila seleccionada a textbox
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                txtDoc.Text = fila.Cells["dni"].Value.ToString();
                txtNom.Text = fila.Cells["nomb"].Value.ToString();
                txtApe.Text = fila.Cells["ape"].Value.ToString();
                cmbRol.SelectedIndex = cmbRol.Items.IndexOf(Convert.ToString(fila.Cells["rol"].Value));
                txtUsu.Text = fila.Cells["user"].Value.ToString();
                txtDir.Text = fila.Cells["dir"].Value.ToString();
                txtTel.Text = fila.Cells["tel"].Value.ToString();
                txtMail.Text = fila.Cells["email"].Value.ToString();
                if(Convert.ToBoolean(fila.Cells["estado"].Value) == true)
                {
                    chkActivo.Checked = true;
                    HabilitarBtn(btnElimUs, true);
                }
                else
                {
                    chkActivo.Checked = false;
                    HabilitarBtn(btnElimUs, false);
                }
                if (Convert.ToBoolean(fila.Cells["bloq"].Value) == true)
                {
                    chkBloqueado.Checked = true;
                    HabilitarBtn(btnDesbloquear, true);
                }
                else
                { 
                    chkBloqueado.Checked = false;
                    HabilitarBtn(btnDesbloquear, false);
                }
                HabilitarBtn(btnCancelar, true);
                HabilitarBtn(btnModUs, true);
                HabilitarBtn(btnGuardar, false);
            }
            else { ConfigDefaultForm(); }
        }

        private void btnCrearUs_Click(object sender, EventArgs e)
        {
            HabilitarBtn(btnCancelar,true);
            HabilitarBtn(btnDesbloquear,false);
            HabilitarBtn(btnCrearUs, false);
            HabilitarBtn(btnElimUs, false);
            HabilitarBtn(btnModUs, false);
            dgvUsuarios.Enabled = false;
            LimpiarDatos();
            HabilitarCampos();
            chkActivo.Checked = true;
            ClickBoton(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfigDefaultForm();
            ClickBoton(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioBE us = CargaUsuario();

            if (us != null)
            {
                int error = 0;

                if (varMod == 0) //Guardar Usuario Nuevo
                {
                    foreach (DataGridViewRow fila in dgvUsuarios.Rows)
                    {
                        if (Convert.ToInt32(fila.Cells[3].Value) == us.dni)
                        {
                            LlenarMensaje("El DNI ingresado ya cuenta con un usuario");
                            ConfigDefaultForm();
                            error = 1;
                            break;
                        }
                        else
                        {
                            if (fila.Cells[4].Value.ToString() == us.user)
                            {
                                LlenarMensaje("El usuario ingresado ya existe");
                                txtUsu.Text = "";
                                error = 1;
                                break;
                            }
                        }
                    }
                    if (error == 0)
                    {
                        try
                        {
                            us.pass = usuarioBLL.GenerarPass(us.ape, us.dni.ToString());
                            usuarioBLL.CrearUsuario(us);
                            ActualizarDGV();
                            LlenarMensaje($"El usuario -- {us.user} -- fue creado exitosamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrio un error en la creacion de usuario: " + ex.Message);
                            ConfigDefaultForm();
                        }
                    }
                }
                else //Guardar Usuario Modificado
                {
                    try
                    {
                        us.cod = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells[0].Value);
                        usuarioBLL.ActualizarUsuario(us);
                        ActualizarDGV();
                        LlenarMensaje($"Usuario -- {us.user} -- actualizado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error en la actualizacion del usuario: " + ex.Message);
                        ConfigDefaultForm();
                    }
                }
            }
        }

        private void btnModUs_Click(object sender, EventArgs e)
        {
            varMod = 1;
            HabilitarBtn(btnCancelar, true);
            HabilitarBtn(btnDesbloquear, false);
            HabilitarBtn(btnCrearUs, false);
            HabilitarBtn(btnElimUs, false);
            HabilitarBtn(btnModUs, false);
            dgvUsuarios.Enabled = false;
            chkActivo.Enabled = true;
            HabilitarBtn(btnGuardar, true);
            HabilitarCampos();
            if( txtTel.Text == " " ) { txtTel.Clear(); }
            if( txtDir.Text == " " ) { txtDir.Clear(); }
            if( txtMail.Text == " ") { txtMail.Clear(); }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea continuar con el desbloqueo?","Desbloquear Usuario",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UsuarioBE aux = new UsuarioBE();
                    aux = ExtraerDatos(dgvUsuarios.SelectedRows[0]);
                    aux.pass = usuarioBLL.GenerarPass(aux.ape, aux.dni.ToString());
                    usuarioBLL.DesbloquearUS(aux);
                    LlenarMensaje("Usuario desbloqueado exitosamente");
                    ActualizarDGV();
                }               
            }
            catch (Exception ex) { MessageBox.Show("Error de comunicacion con la Base de datos. Contacte al Administrador: " + ex.Message); }
        }

        private void btnElimUs_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBE us = ExtraerDatos(dgvUsuarios.SelectedRows[0]);
                if(MessageBox.Show($"Desea eliminar el usuario -- {us.user}  -- ?","Eliminar Usuario", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuarioBLL.EliminarUs(us);
                    ActualizarDGV();
                    LlenarMensaje($"Baja de usuario -- {us.user} -- exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el usuario seleccionado: " + ex.Message);
                ConfigDefaultForm();
            }
        }
    }
}