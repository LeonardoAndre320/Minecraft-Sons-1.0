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
    
        //Organiza os dados e mostra na tela
        public bool mostrar(string Titulo, string Mensagem, string SAG = "Simples,Media,Grave", bool pergunta = false)
        {
            Size = new Size(500, 167);//Volta ao tamanho normal

            lblTitulo.Text = Titulo;
            lblMensagem.Text = Mensagem;
            Pergunta = pergunta;
            string resposta = "a";
            switch (SAG)//Cores de fundo
            {
                case "Simples": BackColor = Color.SteelBlue; break;
                case "Media": BackColor = Color.Goldenrod; break;
                case "Grave": BackColor = Color.IndianRed; break;
                default: BackColor = Color.SteelBlue; break;
            }

            if(pergunta)//Muda os botoes dependendo do tipo de aviso
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

            bool R = false;//retorno
            if(retorno == "s") { R = true; }
            if(retorno == "n") { R = false; }
            Hide();
            return R;
        }

        //Tive que usar o HIDE para "fechar", o close tava dando probelma
        private void bnt1_Click(object sender, EventArgs e)
        {
            if(Pergunta) { retorno = "n"; Hide(); }
        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            if(Pergunta) { retorno = "s"; Hide(); }
            else { Hide(); }
        }
    }
}
