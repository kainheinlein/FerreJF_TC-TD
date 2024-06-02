namespace ProyectoCampo_JuanFer
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbBuscar = new System.Windows.Forms.GroupBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.dbCodigo = new System.Windows.Forms.RadioButton();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(879, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // grbBuscar
            // 
            this.grbBuscar.Controls.Add(this.btnBuscar);
            this.grbBuscar.Controls.Add(this.txtBuscar);
            this.grbBuscar.Controls.Add(this.rbTipo);
            this.grbBuscar.Controls.Add(this.dbCodigo);
            this.grbBuscar.Controls.Add(this.rbNombre);
            this.grbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscar.Location = new System.Drawing.Point(12, 12);
            this.grbBuscar.Name = "grbBuscar";
            this.grbBuscar.Size = new System.Drawing.Size(345, 106);
            this.grbBuscar.TabIndex = 2;
            this.grbBuscar.TabStop = false;
            this.grbBuscar.Text = "Buscar";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(17, 25);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(88, 17);
            this.rbNombre.TabIndex = 0;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "por nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // dbCodigo
            // 
            this.dbCodigo.AutoSize = true;
            this.dbCodigo.Location = new System.Drawing.Point(17, 48);
            this.dbCodigo.Name = "dbCodigo";
            this.dbCodigo.Size = new System.Drawing.Size(85, 17);
            this.dbCodigo.TabIndex = 1;
            this.dbCodigo.TabStop = true;
            this.dbCodigo.Text = "por codigo";
            this.dbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Location = new System.Drawing.Point(17, 71);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(68, 17);
            this.rbTipo.TabIndex = 2;
            this.rbTipo.TabStop = true;
            this.rbTipo.Text = "por tipo";
            this.rbTipo.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(120, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(186, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(392, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 58);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Añadir a Carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 467);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStock";
            this.Text = "Consultar Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbBuscar.ResumeLayout(false);
            this.grbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbTipo;
        private System.Windows.Forms.RadioButton dbCodigo;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregar;
    }
}