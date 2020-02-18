namespace Minecraft_Sons_1._0
{
    partial class Aviso
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.bnt2 = new System.Windows.Forms.Button();
            this.bnt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(14, 33);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(59, 13);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Mensagem";
            // 
            // bnt2
            // 
            this.bnt2.Location = new System.Drawing.Point(397, 63);
            this.bnt2.Name = "bnt2";
            this.bnt2.Size = new System.Drawing.Size(75, 23);
            this.bnt2.TabIndex = 1;
            this.bnt2.Text = "OK";
            this.bnt2.UseVisualStyleBackColor = true;
            this.bnt2.Click += new System.EventHandler(this.bnt2_Click);
            // 
            // bnt1
            // 
            this.bnt1.Location = new System.Drawing.Point(316, 63);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(75, 23);
            this.bnt1.TabIndex = 0;
            this.bnt1.Text = "Não";
            this.bnt1.UseVisualStyleBackColor = true;
            this.bnt1.Click += new System.EventHandler(this.bnt1_Click);
            // 
            // Aviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(484, 98);
            this.Controls.Add(this.bnt1);
            this.Controls.Add(this.bnt2);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button bnt2;
        private System.Windows.Forms.Button bnt1;
    }
}