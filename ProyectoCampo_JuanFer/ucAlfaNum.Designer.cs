namespace ProyectoCampo_JuanFer
{
    partial class ucAlfaNum
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.ptxtTexto = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(18, 18);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(198, 28);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            this.txtTexto.Leave += new System.EventHandler(this.txtTexto_Leave);
            // 
            // ptxtTexto
            // 
            this.ptxtTexto.BackColor = System.Drawing.Color.DimGray;
            this.ptxtTexto.Location = new System.Drawing.Point(18, 43);
            this.ptxtTexto.Name = "ptxtTexto";
            this.ptxtTexto.Size = new System.Drawing.Size(198, 3);
            this.ptxtTexto.TabIndex = 20;
            // 
            // ucAlfaNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptxtTexto);
            this.Controls.Add(this.txtTexto);
            this.Name = "ucAlfaNum";
            this.Size = new System.Drawing.Size(233, 61);
            this.Load += new System.EventHandler(this.ucUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Panel ptxtTexto;
    }
}
