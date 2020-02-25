namespace Minecraft_Sons_1._0
{
    partial class Carregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carregar));
            this.lblCarregando = new System.Windows.Forms.Label();
            this.Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.Color.White;
            this.lblCarregando.Location = new System.Drawing.Point(69, 28);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(105, 20);
            this.lblCarregando.TabIndex = 0;
            this.lblCarregando.Text = "Carregando...";
            // 
            // Imagem
            // 
            this.Imagem.Image = ((System.Drawing.Image)(resources.GetObject("Imagem.Image")));
            this.Imagem.Location = new System.Drawing.Point(13, 13);
            this.Imagem.Name = "Imagem";
            this.Imagem.Size = new System.Drawing.Size(50, 50);
            this.Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagem.TabIndex = 1;
            this.Imagem.TabStop = false;
            // 
            // Carregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(204, 81);
            this.Controls.Add(this.Imagem);
            this.Controls.Add(this.lblCarregando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carregar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.PictureBox Imagem;
    }
}