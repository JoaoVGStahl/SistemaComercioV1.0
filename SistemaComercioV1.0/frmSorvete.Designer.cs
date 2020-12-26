namespace SistemaComercioV1._0
{
    partial class frmSorvete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSorvete));
            this.btnFSS2 = new System.Windows.Forms.Button();
            this.gbCadastro2 = new System.Windows.Forms.GroupBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtSabor2 = new System.Windows.Forms.TextBox();
            this.lblSabor2 = new System.Windows.Forms.Label();
            this.cmbCategoria2 = new System.Windows.Forms.ComboBox();
            this.txtDesc2 = new System.Windows.Forms.TextBox();
            this.lblDescricao2 = new System.Windows.Forms.Label();
            this.lblCategoria2 = new System.Windows.Forms.Label();
            this.gbCadastro2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFSS2
            // 
            this.btnFSS2.Location = new System.Drawing.Point(12, 183);
            this.btnFSS2.Name = "btnFSS2";
            this.btnFSS2.Size = new System.Drawing.Size(101, 74);
            this.btnFSS2.TabIndex = 0;
            this.btnFSS2.Text = "FECHAR";
            this.btnFSS2.UseVisualStyleBackColor = true;
            this.btnFSS2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gbCadastro2
            // 
            this.gbCadastro2.Controls.Add(this.txtValor2);
            this.gbCadastro2.Controls.Add(this.lblValor2);
            this.gbCadastro2.Controls.Add(this.txtSabor2);
            this.gbCadastro2.Controls.Add(this.lblSabor2);
            this.gbCadastro2.Controls.Add(this.cmbCategoria2);
            this.gbCadastro2.Controls.Add(this.txtDesc2);
            this.gbCadastro2.Controls.Add(this.lblDescricao2);
            this.gbCadastro2.Controls.Add(this.lblCategoria2);
            this.gbCadastro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro2.Location = new System.Drawing.Point(12, 12);
            this.gbCadastro2.Name = "gbCadastro2";
            this.gbCadastro2.Size = new System.Drawing.Size(321, 165);
            this.gbCadastro2.TabIndex = 4;
            this.gbCadastro2.TabStop = false;
            this.gbCadastro2.Text = "INFORMAÇÕES DO PRODUTO:";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(114, 123);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(196, 26);
            this.txtValor2.TabIndex = 5;
            this.txtValor2.WordWrap = false;
            this.txtValor2.TextChanged += new System.EventHandler(this.TxtValor2_TextChanged);
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.Location = new System.Drawing.Point(8, 129);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(71, 16);
            this.lblValor2.TabIndex = 22;
            this.lblValor2.Text = "Valor (R$):";
            // 
            // txtSabor2
            // 
            this.txtSabor2.Location = new System.Drawing.Point(114, 25);
            this.txtSabor2.Name = "txtSabor2";
            this.txtSabor2.Size = new System.Drawing.Size(196, 26);
            this.txtSabor2.TabIndex = 3;
            this.txtSabor2.WordWrap = false;
            // 
            // lblSabor2
            // 
            this.lblSabor2.AutoSize = true;
            this.lblSabor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor2.Location = new System.Drawing.Point(6, 31);
            this.lblSabor2.Name = "lblSabor2";
            this.lblSabor2.Size = new System.Drawing.Size(48, 16);
            this.lblSabor2.TabIndex = 20;
            this.lblSabor2.Text = "Sabor:";
            // 
            // cmbCategoria2
            // 
            this.cmbCategoria2.FormattingEnabled = true;
            this.cmbCategoria2.Items.AddRange(new object[] {
            "MASSA",
            "MILK SHAKE",
            "PALITO",
            "PESO"});
            this.cmbCategoria2.Location = new System.Drawing.Point(114, 57);
            this.cmbCategoria2.Name = "cmbCategoria2";
            this.cmbCategoria2.Size = new System.Drawing.Size(196, 28);
            this.cmbCategoria2.TabIndex = 2;
            // 
            // txtDesc2
            // 
            this.txtDesc2.Location = new System.Drawing.Point(114, 91);
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.Size = new System.Drawing.Size(196, 26);
            this.txtDesc2.TabIndex = 4;
            this.txtDesc2.WordWrap = false;
            // 
            // lblDescricao2
            // 
            this.lblDescricao2.AutoSize = true;
            this.lblDescricao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao2.Location = new System.Drawing.Point(6, 97);
            this.lblDescricao2.Name = "lblDescricao2";
            this.lblDescricao2.Size = new System.Drawing.Size(73, 16);
            this.lblDescricao2.TabIndex = 6;
            this.lblDescricao2.Text = "Descrição:";
            // 
            // lblCategoria2
            // 
            this.lblCategoria2.AutoSize = true;
            this.lblCategoria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria2.Location = new System.Drawing.Point(6, 63);
            this.lblCategoria2.Name = "lblCategoria2";
            this.lblCategoria2.Size = new System.Drawing.Size(70, 16);
            this.lblCategoria2.TabIndex = 4;
            this.lblCategoria2.Text = "Categoria:";
            // 
            // frmSorvete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 275);
            this.Controls.Add(this.gbCadastro2);
            this.Controls.Add(this.btnFSS2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSorvete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSorvete";
            this.gbCadastro2.ResumeLayout(false);
            this.gbCadastro2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFSS2;
        private System.Windows.Forms.GroupBox gbCadastro2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtSabor2;
        private System.Windows.Forms.Label lblSabor2;
        protected System.Windows.Forms.ComboBox cmbCategoria2;
        private System.Windows.Forms.TextBox txtDesc2;
        private System.Windows.Forms.Label lblDescricao2;
        private System.Windows.Forms.Label lblCategoria2;
    }
}