using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Sons_1._0
{
    public partial class Aviso : Form
    {
        public Aviso()
        {
            InitializeComponent();
        }

        string retorno = "";
        bool Pergunta = false;
        public bool mostrar(string Titulo, string Mensagem, string SAG = "Simples,Aviso,Grave", bool pergunta = false,string resposta = "sim/não")
        {
            lblTitulo.Text = Titulo;
            lblMensagem.Text = Mensagem;
            Pergunta = pergunta;

            switch (SAG)
            {
                case "simples": BackColor = Color.SteelBlue; break;
                case "media": BackColor = Color.Goldenrod; break;
                case "grave": BackColor = Color.IndianRed; break;
                default: BackColor = Color.SteelBlue; break;
            }

            if(pergunta)
            {
                bnt1.Visible = true;
                bnt1.Enabled = true;
                bnt2.Text = "Sim";
            }
            else
            {
                bnt1.Visible = false;
                bnt1.Enabled = false;
                bnt2.Text = "OK";
            }
            //Aumenta a tela para o tamanho certo
            for(int i = 0; Size.Width < lblTitulo.Size.Width + 38;i++)
            {
                Size = new Size(i, Size.Height);
            }

            for(int i=0;Size.Width < lblMensagem.Size.Width + 38;i++)
            {
                Size = new Size(i, Size.Height);
            }
            for(int i=0;Size.Height < lblMensagem.Size.Height + 124;i++)
            {
                Size = new Size(Size.Width, i);
            }

            //Ajusta os botoes na janela
            bnt1.Location = new Point(Size.Width - 184, Size.Height - 74);
            bnt2.Location = new Point(Size.Width - 103, Size.Height - 74);

            ShowDialog();
            for (;resposta != "";)
            {
                break;
            }

            bool R = false;
            if(retorno == "s") { R = true; }
            if(retorno == "n") { R = false; }
            Dispose(true);
            return R;
        }

        //case "simples":  A.BackColor = Color.SteelBlue; break;
        //case "media":  A.BackColor = Color.Goldenrod; break;
        //case "grave":  A.BackColor = Color.IndianRed; break;

        private void bnt1_Click(object sender, EventArgs e)
        {
            if(Pergunta) { retorno = "n"; Dispose(true); }
        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            if(Pergunta) { retorno = "s"; Dispose(true); }
            else { Dispose(true); }
        }
    }
}
