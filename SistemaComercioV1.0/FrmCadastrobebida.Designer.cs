namespace SistemaComercioV1._0
{
    partial class frmCadatroBebida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadatroBebida));
            this.btnFSS = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFSS
            // 
            this.btnFSS.Location = new System.Drawing.Point(6, 213);
            this.btnFSS.Name = "btnFSS";
            this.btnFSS.Size = new System.Drawing.Size(101, 74);
            this.btnFSS.TabIndex = 8;
            this.btnFSS.Text = "FECHAR \r\nSEM \r\nSALVAR";
            this.btnFSS.UseVisualStyleBackColor = true;
            this.btnFSS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(226, 213);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 74);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.EnabledChanged += new System.EventHandler(this.BtnSalvar_EnabledChanged);
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.txtValor);
            this.gbCadastro.Controls.Add(this.lblValor);
            this.gbCadastro.Controls.Add(this.txtSabor);
            this.gbCadastro.Controls.Add(this.lblSabor);
            this.gbCadastro.Controls.Add(this.cmbCategoria);
            this.gbCadastro.Controls.Add(this.txtDesc);
            this.gbCadastro.Controls.Add(this.lblDescricao);
            this.gbCadastro.Controls.Add(this.lblCategoria);
            this.gbCadastro.Controls.Add(this.txtNome);
            this.gbCadastro.Controls.Add(this.lblNome);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.Location = new System.Drawing.Point(6, 12);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(321, 195);
            this.gbCadastro.TabIndex = 3;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "INFORMAÇÕES DO PRODUTO:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(114, 156);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(196, 26);
            this.txtValor.TabIndex = 5;
            this.txtValor.WordWrap = false;
            this.txtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            this.txtValor.Enter += new System.EventHandler(this.TxtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.TxtValor_Leave);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(5, 162);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(71, 16);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "Valor (R$):";
            // 
            // txtSabor
            // 
            this.txtSabor.Location = new System.Drawing.Point(114, 92);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(196, 26);
            this.txtSabor.TabIndex = 3;
            this.txtSabor.WordWrap = false;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.Location = new System.Drawing.Point(6, 98);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(48, 16);
            this.lblSabor.TabIndex = 20;
            this.lblSabor.Text = "Sabor:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "LATA 350ml",
            "LATÃO 473ml",
            "GARRAFA 1L ",
            "GARRAFA 2L",
            "GARRAFA 3L",
            "GARRAFA 600ml",
            "CAÇULINHA 237ml",
            "TEST"});
            this.cmbCategoria.Location = new System.Drawing.Point(114, 58);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(196, 28);
            this.cmbCategoria.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(114, 124);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(196, 26);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.WordWrap = false;
            this.txtDesc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDesc_KeyPress);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 130);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 16);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 64);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(70, 16);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(196, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(116, 213);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 74);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // frmCadatroBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 292);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFSS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadatroBebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR BEBIDA";
            this.Load += new System.EventHandler(this.FrmCadatroBebida_Load);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFSS;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtDesc;
        protected System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
    }
}