﻿namespace ProyectoCampo_JuanFer
{
    partial class frmModClave
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
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblRep = new System.Windows.Forms.Label();
            this.txtClaveRep = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblActual = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(34, 257);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(282, 26);
            this.txtClave.TabIndex = 0;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Visible = false;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevo.Location = new System.Drawing.Point(92, 232);
            this.lblNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(163, 20);
            this.lblNuevo.TabIndex = 1;
            this.lblNuevo.Text = "Nueva Contraseña";
            this.lblNuevo.Visible = false;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.Location = new System.Drawing.Point(21, 14);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(309, 71);
            this.lblInstrucciones.TabIndex = 2;
            this.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInstrucciones.Click += new System.EventHandler(this.lblInstrucciones_Click);
            // 
            // lblRep
            // 
            this.lblRep.AutoSize = true;
            this.lblRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRep.Location = new System.Drawing.Point(88, 311);
            this.lblRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(172, 20);
            this.lblRep.TabIndex = 4;
            this.lblRep.Text = "Repetir Contraseña";
            this.lblRep.Visible = false;
            // 
            // txtClaveRep
            // 
            this.txtClaveRep.Location = new System.Drawing.Point(34, 335);
            this.txtClaveRep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClaveRep.Name = "txtClaveRep";
            this.txtClaveRep.Size = new System.Drawing.Size(282, 26);
            this.txtClaveRep.TabIndex = 3;
            this.txtClaveRep.UseSystemPasswordChar = true;
            this.txtClaveRep.Visible = false;
            this.txtClaveRep.TextChanged += new System.EventHandler(this.txtClaveRep_TextChanged);
            this.txtClaveRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveRep_KeyPress);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(14, 386);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(324, 63);
            this.lblError.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(120, 454);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 49);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(120, 512);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 49);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActual.Location = new System.Drawing.Point(93, 112);
            this.lblActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(164, 20);
            this.lblActual.TabIndex = 9;
            this.lblActual.Text = "Contraseña Actual";
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(34, 137);
            this.txtActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(282, 26);
            this.txtActual.TabIndex = 8;
            this.txtActual.UseSystemPasswordChar = true;
            this.txtActual.TextChanged += new System.EventHandler(this.txtActual_TextChanged);
            this.txtActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActual_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(120, 177);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 35);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Confirmar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmModClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 580);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblRep);
            this.Controls.Add(this.txtClaveRep);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.txtClave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.frmModClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblRep;
        private System.Windows.Forms.TextBox txtClaveRep;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.Button btnLogin;
    }
}