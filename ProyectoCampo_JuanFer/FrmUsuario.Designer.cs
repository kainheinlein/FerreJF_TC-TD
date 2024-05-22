namespace ProyectoCampo_JuanFer
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnElimUs = new System.Windows.Forms.Button();
            this.btnModUs = new System.Windows.Forms.Button();
            this.btnCrearUs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.rbBloqueados = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.ptxtMail = new System.Windows.Forms.Panel();
            this.ptxtTel = new System.Windows.Forms.Panel();
            this.ptxtDir = new System.Windows.Forms.Panel();
            this.ptxtPass = new System.Windows.Forms.Panel();
            this.ptxtUsu = new System.Windows.Forms.Panel();
            this.ptxtApe = new System.Windows.Forms.Panel();
            this.ptxtNom = new System.Windows.Forms.Panel();
            this.ptxtDoc = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.chkBloqueado = new System.Windows.Forms.CheckBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblBloq = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.GroupBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.g.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE USUARIOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnDesbloquear);
            this.groupBox1.Controls.Add(this.btnElimUs);
            this.groupBox1.Controls.Add(this.btnModUs);
            this.groupBox1.Controls.Add(this.btnCrearUs);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1282, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(225, 650);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(26, 549);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(177, 74);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(26, 466);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 74);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(26, 382);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(177, 74);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquear.Location = new System.Drawing.Point(26, 300);
            this.btnDesbloquear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(177, 74);
            this.btnDesbloquear.TabIndex = 16;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            // 
            // btnElimUs
            // 
            this.btnElimUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimUs.Location = new System.Drawing.Point(26, 218);
            this.btnElimUs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElimUs.Name = "btnElimUs";
            this.btnElimUs.Size = new System.Drawing.Size(177, 74);
            this.btnElimUs.TabIndex = 15;
            this.btnElimUs.Text = "Eliminar Usuario";
            this.btnElimUs.UseVisualStyleBackColor = true;
            // 
            // btnModUs
            // 
            this.btnModUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModUs.Location = new System.Drawing.Point(26, 134);
            this.btnModUs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModUs.Name = "btnModUs";
            this.btnModUs.Size = new System.Drawing.Size(177, 74);
            this.btnModUs.TabIndex = 14;
            this.btnModUs.Text = "Modificar Usuario";
            this.btnModUs.UseVisualStyleBackColor = true;
            this.btnModUs.Click += new System.EventHandler(this.btnModUs_Click);
            // 
            // btnCrearUs
            // 
            this.btnCrearUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUs.Location = new System.Drawing.Point(26, 51);
            this.btnCrearUs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearUs.Name = "btnCrearUs";
            this.btnCrearUs.Size = new System.Drawing.Size(177, 74);
            this.btnCrearUs.TabIndex = 13;
            this.btnCrearUs.Text = "Crear Usuario";
            this.btnCrearUs.UseVisualStyleBackColor = true;
            this.btnCrearUs.Click += new System.EventHandler(this.btnCrearUs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvUsuarios);
            this.groupBox2.Controls.Add(this.rbBloqueados);
            this.groupBox2.Controls.Add(this.rbActivos);
            this.groupBox2.Controls.Add(this.rbTodos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1246, 568);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(9, 69);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.RowTemplate.Height = 30;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1228, 490);
            this.dgvUsuarios.TabIndex = 22;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // rbBloqueados
            // 
            this.rbBloqueados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbBloqueados.AutoSize = true;
            this.rbBloqueados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBloqueados.Location = new System.Drawing.Point(1087, 28);
            this.rbBloqueados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBloqueados.Name = "rbBloqueados";
            this.rbBloqueados.Size = new System.Drawing.Size(146, 28);
            this.rbBloqueados.TabIndex = 21;
            this.rbBloqueados.Text = "Bloqueados";
            this.rbBloqueados.UseVisualStyleBackColor = true;
            // 
            // rbActivos
            // 
            this.rbActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbActivos.AutoSize = true;
            this.rbActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivos.Location = new System.Drawing.Point(954, 28);
            this.rbActivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(102, 28);
            this.rbActivos.TabIndex = 20;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(836, 28);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(94, 28);
            this.rbTodos.TabIndex = 19;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDatos.Controls.Add(this.ptxtMail);
            this.gbDatos.Controls.Add(this.ptxtTel);
            this.gbDatos.Controls.Add(this.ptxtDir);
            this.gbDatos.Controls.Add(this.ptxtPass);
            this.gbDatos.Controls.Add(this.ptxtUsu);
            this.gbDatos.Controls.Add(this.ptxtApe);
            this.gbDatos.Controls.Add(this.ptxtNom);
            this.gbDatos.Controls.Add(this.ptxtDoc);
            this.gbDatos.Controls.Add(this.txtPass);
            this.gbDatos.Controls.Add(this.chkBloqueado);
            this.gbDatos.Controls.Add(this.lblPass);
            this.gbDatos.Controls.Add(this.cmbRol);
            this.gbDatos.Controls.Add(this.chkActivo);
            this.gbDatos.Controls.Add(this.txtMail);
            this.gbDatos.Controls.Add(this.lblActivo);
            this.gbDatos.Controls.Add(this.lblCorreo);
            this.gbDatos.Controls.Add(this.lblBloq);
            this.gbDatos.Controls.Add(this.txtTel);
            this.gbDatos.Controls.Add(this.lblTelefono);
            this.gbDatos.Controls.Add(this.txtDir);
            this.gbDatos.Controls.Add(this.lblDireccion);
            this.gbDatos.Controls.Add(this.lblRol);
            this.gbDatos.Controls.Add(this.txtUsu);
            this.gbDatos.Controls.Add(this.lblUsuario);
            this.gbDatos.Controls.Add(this.txtApe);
            this.gbDatos.Controls.Add(this.lblApellido);
            this.gbDatos.Controls.Add(this.txtNom);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.txtDoc);
            this.gbDatos.Controls.Add(this.lblDNI);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(27, 686);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Size = new System.Drawing.Size(854, 266);
            this.gbDatos.TabIndex = 14;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Usuario";
            // 
            // ptxtMail
            // 
            this.ptxtMail.BackColor = System.Drawing.Color.DimGray;
            this.ptxtMail.Location = new System.Drawing.Point(562, 250);
            this.ptxtMail.Name = "ptxtMail";
            this.ptxtMail.Size = new System.Drawing.Size(280, 3);
            this.ptxtMail.TabIndex = 20;
            // 
            // ptxtTel
            // 
            this.ptxtTel.BackColor = System.Drawing.Color.DimGray;
            this.ptxtTel.Location = new System.Drawing.Point(562, 206);
            this.ptxtTel.Name = "ptxtTel";
            this.ptxtTel.Size = new System.Drawing.Size(280, 3);
            this.ptxtTel.TabIndex = 20;
            // 
            // ptxtDir
            // 
            this.ptxtDir.BackColor = System.Drawing.Color.DimGray;
            this.ptxtDir.Location = new System.Drawing.Point(564, 162);
            this.ptxtDir.Name = "ptxtDir";
            this.ptxtDir.Size = new System.Drawing.Size(280, 3);
            this.ptxtDir.TabIndex = 20;
            // 
            // ptxtPass
            // 
            this.ptxtPass.BackColor = System.Drawing.Color.DimGray;
            this.ptxtPass.Location = new System.Drawing.Point(140, 250);
            this.ptxtPass.Name = "ptxtPass";
            this.ptxtPass.Size = new System.Drawing.Size(280, 3);
            this.ptxtPass.TabIndex = 20;
            // 
            // ptxtUsu
            // 
            this.ptxtUsu.BackColor = System.Drawing.Color.DimGray;
            this.ptxtUsu.Location = new System.Drawing.Point(138, 200);
            this.ptxtUsu.Name = "ptxtUsu";
            this.ptxtUsu.Size = new System.Drawing.Size(280, 3);
            this.ptxtUsu.TabIndex = 20;
            // 
            // ptxtApe
            // 
            this.ptxtApe.BackColor = System.Drawing.Color.DimGray;
            this.ptxtApe.Location = new System.Drawing.Point(138, 154);
            this.ptxtApe.Name = "ptxtApe";
            this.ptxtApe.Size = new System.Drawing.Size(280, 3);
            this.ptxtApe.TabIndex = 20;
            // 
            // ptxtNom
            // 
            this.ptxtNom.BackColor = System.Drawing.Color.DimGray;
            this.ptxtNom.Location = new System.Drawing.Point(138, 111);
            this.ptxtNom.Name = "ptxtNom";
            this.ptxtNom.Size = new System.Drawing.Size(280, 3);
            this.ptxtNom.TabIndex = 20;
            // 
            // ptxtDoc
            // 
            this.ptxtDoc.BackColor = System.Drawing.Color.DimGray;
            this.ptxtDoc.Location = new System.Drawing.Point(138, 66);
            this.ptxtDoc.Name = "ptxtDoc";
            this.ptxtDoc.Size = new System.Drawing.Size(280, 3);
            this.ptxtDoc.TabIndex = 19;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPass.Enabled = false;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(138, 218);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(280, 30);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // chkBloqueado
            // 
            this.chkBloqueado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkBloqueado.AutoSize = true;
            this.chkBloqueado.Enabled = false;
            this.chkBloqueado.Location = new System.Drawing.Point(772, 32);
            this.chkBloqueado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBloqueado.Name = "chkBloqueado";
            this.chkBloqueado.Size = new System.Drawing.Size(22, 21);
            this.chkBloqueado.TabIndex = 18;
            this.chkBloqueado.UseVisualStyleBackColor = true;
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(14, 224);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(113, 22);
            this.lblPass.TabIndex = 16;
            this.lblPass.Text = "Contraseña";
            // 
            // cmbRol
            // 
            this.cmbRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Enabled = false;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(562, 82);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(280, 33);
            this.cmbRol.TabIndex = 6;
            this.cmbRol.SelectedValueChanged += new System.EventHandler(this.cmbRol_SelectedValueChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkActivo.AutoSize = true;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(567, 32);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(22, 21);
            this.chkActivo.TabIndex = 17;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMail.Enabled = false;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(562, 218);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(280, 30);
            this.txtMail.TabIndex = 9;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // lblActivo
            // 
            this.lblActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(492, 28);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(65, 22);
            this.lblActivo.TabIndex = 18;
            this.lblActivo.Text = "Activo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(452, 224);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 22);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Text = "E-mail";
            // 
            // lblBloq
            // 
            this.lblBloq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBloq.AutoSize = true;
            this.lblBloq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloq.Location = new System.Drawing.Point(650, 28);
            this.lblBloq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloq.Name = "lblBloq";
            this.lblBloq.Size = new System.Drawing.Size(105, 22);
            this.lblBloq.TabIndex = 16;
            this.lblBloq.Text = "Bloqueado";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(562, 174);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(280, 30);
            this.txtTel.TabIndex = 8;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(452, 178);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 22);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtDir
            // 
            this.txtDir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDir.Enabled = false;
            this.txtDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(562, 129);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(280, 30);
            this.txtDir.TabIndex = 7;
            this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(452, 134);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(94, 22);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblRol
            // 
            this.lblRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(452, 82);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(40, 22);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Rol";
            // 
            // txtUsu
            // 
            this.txtUsu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsu.Enabled = false;
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.Location = new System.Drawing.Point(138, 168);
            this.txtUsu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(280, 30);
            this.txtUsu.TabIndex = 4;
            this.txtUsu.TextChanged += new System.EventHandler(this.txtUsu_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(14, 172);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 22);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtApe
            // 
            this.txtApe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApe.Enabled = false;
            this.txtApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApe.Location = new System.Drawing.Point(138, 123);
            this.txtApe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(278, 30);
            this.txtApe.TabIndex = 3;
            this.txtApe.TextChanged += new System.EventHandler(this.txtApe_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(14, 128);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 22);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNom.Enabled = false;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(138, 78);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(280, 30);
            this.txtNom.TabIndex = 2;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 82);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDoc
            // 
            this.txtDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDoc.Enabled = false;
            this.txtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDoc.Location = new System.Drawing.Point(138, 34);
            this.txtDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(280, 30);
            this.txtDoc.TabIndex = 1;
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(14, 38);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 22);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            // 
            // g
            // 
            this.g.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.g.Controls.Add(this.txtMensaje);
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.Location = new System.Drawing.Point(890, 686);
            this.g.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g.Name = "g";
            this.g.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g.Size = new System.Drawing.Size(384, 266);
            this.g.TabIndex = 15;
            this.g.TabStop = false;
            this.g.Text = "Mensajes";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMensaje.Location = new System.Drawing.Point(9, 38);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.Size = new System.Drawing.Size(364, 216);
            this.txtMensaje.TabIndex = 17;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1526, 962);
            this.Controls.Add(this.g);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1534, 974);
            this.Name = "FrmUsuario";
            this.Text = "Gestion Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnElimUs;
        private System.Windows.Forms.Button btnModUs;
        private System.Windows.Forms.Button btnCrearUs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBloqueados;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblBloq;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.CheckBox chkBloqueado;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Panel ptxtApe;
        private System.Windows.Forms.Panel ptxtUsu;
        private System.Windows.Forms.Panel ptxtNom;
        private System.Windows.Forms.Panel ptxtDoc;
        private System.Windows.Forms.Panel ptxtMail;
        private System.Windows.Forms.Panel ptxtTel;
        private System.Windows.Forms.Panel ptxtDir;
        private System.Windows.Forms.Panel ptxtPass;
    }
}