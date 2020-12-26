namespace SistemaComercioV1._0
{
    partial class frmPrincipal
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
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnVenda = new System.Windows.Forms.Button();
            this.BtnHist = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(114, 203);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(193, 74);
            this.btnEncerrar.TabIndex = 0;
            this.btnEncerrar.Text = "ENCERRAR";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(65, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(307, 31);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "NOME DO COMÉRCIO ";
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(12, 43);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(193, 74);
            this.btnVenda.TabIndex = 2;
            this.btnVenda.Text = "VENDA";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // BtnHist
            // 
            this.BtnHist.Location = new System.Drawing.Point(211, 43);
            this.BtnHist.Name = "BtnHist";
            this.BtnHist.Size = new System.Drawing.Size(193, 74);
            this.BtnHist.TabIndex = 3;
            this.BtnHist.Text = "HISTÓRICO \r\nDE\r\nVENDAS\r\n";
            this.BtnHist.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 123);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 74);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "CADASTRAR PRODUTO";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(211, 123);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(193, 74);
            this.btnPesquisa.TabIndex = 5;
            this.btnPesquisa.Text = "PESQUISAR PRODUTO";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 284);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.BtnHist);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnEncerrar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(431, 323);
            this.MinimumSize = new System.Drawing.Size(431, 323);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button BtnHist;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisa;
    }
}

