namespace sla
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btmenssage = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblsenha = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btmenssage
            // 
            this.btmenssage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btmenssage.Font = new System.Drawing.Font("Swis721 Blk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenssage.Location = new System.Drawing.Point(583, 308);
            this.btmenssage.Name = "btmenssage";
            this.btmenssage.Size = new System.Drawing.Size(162, 39);
            this.btmenssage.TabIndex = 2;
            this.btmenssage.Text = "ENTRE";
            this.btmenssage.UseVisualStyleBackColor = false;
            this.btmenssage.Click += new System.EventHandler(this.btmenssage_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblnome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnome.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(628, 136);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(62, 22);
            this.lblnome.TabIndex = 4;
            this.lblnome.Text = "Nome";
            // 
            // txbnome
            // 
            this.txbnome.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txbnome.Location = new System.Drawing.Point(564, 175);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(195, 20);
            this.txbnome.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sla.Properties.Resources.Captura_de_tela_2023_08_16_114123;
            this.pictureBox1.Location = new System.Drawing.Point(-158, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(965, 487);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblsenha
            // 
            this.lblsenha.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblsenha.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblsenha.Location = new System.Drawing.Point(618, 201);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(82, 32);
            this.lblsenha.TabIndex = 7;
            this.lblsenha.Text = "Senha";
            this.lblsenha.UseVisualStyleBackColor = false;
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txbSenha.Location = new System.Drawing.Point(564, 248);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(195, 20);
            this.txbSenha.TabIndex = 8;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btmenssage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btmenssage;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button lblsenha;
        private System.Windows.Forms.TextBox txbSenha;
    }
}

