namespace Minecraft_Sons_1._0
{
    partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.ListaImagens = new System.Windows.Forms.ImageList(this.components);
            this.ImagemInicial = new System.Windows.Forms.PictureBox();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntAbrir = new System.Windows.Forms.Button();
            this.GrupoRecentes = new System.Windows.Forms.GroupBox();
            this.lblR10 = new System.Windows.Forms.Label();
            this.lblR9 = new System.Windows.Forms.Label();
            this.lblR8 = new System.Windows.Forms.Label();
            this.lblR7 = new System.Windows.Forms.Label();
            this.lblR6 = new System.Windows.Forms.Label();
            this.lblR5 = new System.Windows.Forms.Label();
            this.lblR4 = new System.Windows.Forms.Label();
            this.lblR3 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.Buscador = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemInicial)).BeginInit();
            this.GrupoRecentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaImagens
            // 
            this.ListaImagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagens.ImageStream")));
            this.ListaImagens.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagens.Images.SetKeyName(0, "Note-block.png");
            // 
            // ImagemInicial
            // 
            this.ImagemInicial.Image = ((System.Drawing.Image)(resources.GetObject("ImagemInicial.Image")));
            this.ImagemInicial.Location = new System.Drawing.Point(13, 13);
            this.ImagemInicial.Name = "ImagemInicial";
            this.ImagemInicial.Size = new System.Drawing.Size(100, 100);
            this.ImagemInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemInicial.TabIndex = 0;
            this.ImagemInicial.TabStop = false;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(13, 119);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(100, 23);
            this.bntNovo.TabIndex = 1;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntAbrir
            // 
            this.bntAbrir.Location = new System.Drawing.Point(13, 148);
            this.bntAbrir.Name = "bntAbrir";
            this.bntAbrir.Size = new System.Drawing.Size(100, 23);
            this.bntAbrir.TabIndex = 2;
            this.bntAbrir.Text = "Abrir";
            this.bntAbrir.UseVisualStyleBackColor = true;
            this.bntAbrir.Click += new System.EventHandler(this.bntAbrir_Click);
            // 
            // GrupoRecentes
            // 
            this.GrupoRecentes.Controls.Add(this.lblR10);
            this.GrupoRecentes.Controls.Add(this.lblR9);
            this.GrupoRecentes.Controls.Add(this.lblR8);
            this.GrupoRecentes.Controls.Add(this.lblR7);
            this.GrupoRecentes.Controls.Add(this.lblR6);
            this.GrupoRecentes.Controls.Add(this.lblR5);
            this.GrupoRecentes.Controls.Add(this.lblR4);
            this.GrupoRecentes.Controls.Add(this.lblR3);
            this.GrupoRecentes.Controls.Add(this.lblR2);
            this.GrupoRecentes.Controls.Add(this.lblR1);
            this.GrupoRecentes.ForeColor = System.Drawing.Color.White;
            this.GrupoRecentes.Location = new System.Drawing.Point(119, 13);
            this.GrupoRecentes.Name = "GrupoRecentes";
            this.GrupoRecentes.Size = new System.Drawing.Size(329, 158);
            this.GrupoRecentes.TabIndex = 3;
            this.GrupoRecentes.TabStop = false;
            this.GrupoRecentes.Text = "Recentes(0)";
            // 
            // lblR10
            // 
            this.lblR10.AutoSize = true;
            this.lblR10.Location = new System.Drawing.Point(6, 133);
            this.lblR10.Name = "lblR10";
            this.lblR10.Size = new System.Drawing.Size(63, 13);
            this.lblR10.TabIndex = 0;
            this.lblR10.Text = "Recente 10";
            this.lblR10.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR10.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // lblR9
            // 
            this.lblR9.AutoSize = true;
            this.lblR9.Location = new System.Drawing.Point(6, 120);
            this.lblR9.Name = "lblR9";
            this.lblR9.Size = new System.Drawing.Size(57, 13);
            this.lblR9.TabIndex = 0;
            this.lblR9.Text = "Recente 9";
            this.lblR9.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR9.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // lblR8
            // 
            this.lblR8.AutoSize = true;
            this.lblR8.Location = new System.Drawing.Point(6, 107);
            this.lblR8.Name = "lblR8";
            this.lblR8.Size = new System.Drawing.Size(57, 13);
            this.lblR8.TabIndex = 0;
            this.lblR8.Text = "Recente 8";
            this.lblR8.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR8.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // lblR7
            // 
            this.lblR7.AutoSize = true;
            this.lblR7.Location = new System.Drawing.Point(6, 94);
            this.lblR7.Name = "lblR7";
            this.lblR7.Size = new System.Drawing.Size(57, 13);
            this.lblR7.TabIndex = 0;
            this.lblR7.Text = "Recente 7";
            this.lblR7.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR7.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // lblR6
            // 
            this.lblR6.AutoSize = true;
            this.lblR6.Location = new System.Drawing.Point(6, 81);
            this.lblR6.Name = "lblR6";
            this.lblR6.Size = new System.Drawing.Size(57, 13);
            this.lblR6.TabIndex = 0;
            this.lblR6.Text = "Recente 6";
            this.lblR6.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR6.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // lblR5
            // 
            this.lblR5.AutoSize = true;
            this.lblR5.Location = new System.Drawing.Point(6, 68);
            this.lblR5.Name = "lblR5";
            this.lblR5.Size = new System.Drawing.Size(57, 13);
            this.lblR5.TabIndex = 0;
            this.lblR5.Text = "Recente 5";
            this.lblR5.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR5.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // lblR4
            // 
            this.lblR4.AutoSize = true;
            this.lblR4.Location = new System.Drawing.Point(6, 55);
            this.lblR4.Name = "lblR4";
            this.lblR4.Size = new System.Drawing.Size(57, 13);
            this.lblR4.TabIndex = 0;
            this.lblR4.Text = "Recente 4";
            this.lblR4.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR4.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // lblR3
            // 
            this.lblR3.AutoSize = true;
            this.lblR3.Location = new System.Drawing.Point(6, 42);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(57, 13);
            this.lblR3.TabIndex = 0;
            this.lblR3.Text = "Recente 3";
            this.lblR3.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR3.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(6, 29);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(57, 13);
            this.lblR2.TabIndex = 0;
            this.lblR2.Text = "Recente 2";
            this.lblR2.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR2.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(6, 16);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(57, 13);
            this.lblR1.TabIndex = 0;
            this.lblR1.Text = "Recente 1";
            this.lblR1.MouseEnter += new System.EventHandler(this.MudarMouseE);
            this.lblR1.MouseLeave += new System.EventHandler(this.MudarMouseS);
            // 
            // Buscador
            // 
            this.Buscador.FileName = "openFileDialog1";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(460, 183);
            this.Controls.Add(this.GrupoRecentes);
            this.Controls.Add(this.bntAbrir);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.ImagemInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ImagemInicial)).EndInit();
            this.GrupoRecentes.ResumeLayout(false);
            this.GrupoRecentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ListaImagens;
        private System.Windows.Forms.PictureBox ImagemInicial;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntAbrir;
        private System.Windows.Forms.GroupBox GrupoRecentes;
        private System.Windows.Forms.Label lblR10;
        private System.Windows.Forms.Label lblR9;
        private System.Windows.Forms.Label lblR8;
        private System.Windows.Forms.Label lblR7;
        private System.Windows.Forms.Label lblR6;
        private System.Windows.Forms.Label lblR5;
        private System.Windows.Forms.Label lblR4;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.OpenFileDialog Buscador;
    }
}

