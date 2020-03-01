namespace Minecraft_Sons_1._0
{
    partial class TelaPrincipal
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
            this.BarraSuperior = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.PainelConfig = new System.Windows.Forms.Panel();
            this.PainelItens = new System.Windows.Forms.Panel();
            this.CaixaLista = new System.Windows.Forms.ListBox();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.BarraSuperior.SuspendLayout();
            this.PainelItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.White;
            this.BarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem,
            this.projetoToolStripMenuItem});
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(418, 24);
            this.BarraSuperior.TabIndex = 0;
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.opçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.programaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.programaToolStripMenuItem.Text = "Programa";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 6);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar como";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(136, 6);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.propiedadesToolStripMenuItem});
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.projetoToolStripMenuItem.Text = "Projeto";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 6);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(0, 261);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(418, 22);
            this.Status.TabIndex = 1;
            this.Status.Text = "statusStrip1";
            // 
            // PainelConfig
            // 
            this.PainelConfig.BackColor = System.Drawing.Color.SteelBlue;
            this.PainelConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PainelConfig.Location = new System.Drawing.Point(0, 147);
            this.PainelConfig.Name = "PainelConfig";
            this.PainelConfig.Size = new System.Drawing.Size(418, 114);
            this.PainelConfig.TabIndex = 2;
            // 
            // PainelItens
            // 
            this.PainelItens.BackColor = System.Drawing.Color.SteelBlue;
            this.PainelItens.Controls.Add(this.CaixaLista);
            this.PainelItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelItens.Location = new System.Drawing.Point(0, 24);
            this.PainelItens.Name = "PainelItens";
            this.PainelItens.Size = new System.Drawing.Size(418, 123);
            this.PainelItens.TabIndex = 3;
            // 
            // CaixaLista
            // 
            this.CaixaLista.BackColor = System.Drawing.Color.SteelBlue;
            this.CaixaLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaixaLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaixaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaLista.ForeColor = System.Drawing.Color.White;
            this.CaixaLista.FormattingEnabled = true;
            this.CaixaLista.ItemHeight = 15;
            this.CaixaLista.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3",
            "Item4",
            "Item5",
            "Item6",
            "Item7",
            "Item8",
            "Item9",
            "Item10"});
            this.CaixaLista.Location = new System.Drawing.Point(0, 0);
            this.CaixaLista.Name = "CaixaLista";
            this.CaixaLista.Size = new System.Drawing.Size(418, 123);
            this.CaixaLista.TabIndex = 0;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(418, 283);
            this.Controls.Add(this.PainelItens);
            this.Controls.Add(this.PainelConfig);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.BarraSuperior);
            this.MainMenuStrip = this.BarraSuperior;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.PainelItens.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraSuperior;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.Panel PainelConfig;
        protected System.Windows.Forms.Panel PainelItens;
        private System.Windows.Forms.ListBox CaixaLista;
        private System.Windows.Forms.Timer Temporizador;
    }
}