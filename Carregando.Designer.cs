namespace Minecraft_Sons_1._0
{
    partial class Carregando
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
            this.lblPorcentos = new System.Windows.Forms.Label();
            this.Barra = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblPorcentos
            // 
            this.lblPorcentos.AutoSize = true;
            this.lblPorcentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentos.ForeColor = System.Drawing.Color.White;
            this.lblPorcentos.Location = new System.Drawing.Point(13, 13);
            this.lblPorcentos.Name = "lblPorcentos";
            this.lblPorcentos.Size = new System.Drawing.Size(163, 20);
            this.lblPorcentos.TabIndex = 0;
            this.lblPorcentos.Text = "Carregando(batata%)";
            // 
            // Barra
            // 
            this.Barra.Location = new System.Drawing.Point(12, 59);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(400, 10);
            this.Barra.TabIndex = 1;
            // 
            // Carregando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(424, 81);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.lblPorcentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carregando";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPorcentos;
        public System.Windows.Forms.ProgressBar Barra;
    }
}