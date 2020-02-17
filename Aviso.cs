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
        bool Pergunta = false;

        bool resposta = false;
        bool respondido = false;
        public static bool mostrar(string Titulo, string Mensagem, string SMG = "simples,media,grave", bool Pergunta = false, string RespostaPadrao = "sim/não")
        {

            Aviso A = new Aviso();
            A.Pergunta = Pergunta;
            A.lblTitulo.Text = Titulo;//mostra as mensagens
            A.lblMensagem.Text = Mensagem;

            switch(SMG)//escolhe a cor do fundo
            {
                case "simples":  A.BackColor = Color.SteelBlue; break;
                case "media":  A.BackColor = Color.Goldenrod; break;
                case "grave":  A.BackColor = Color.IndianRed; break;
                default: A.BackColor = Color.Goldenrod; break;
            }

            if(Pergunta)
            {
                A.bnt1.Visible = true;
                A.bnt2.Text = "Sim";

                if (RespostaPadrao == "sim")
                    A.bnt2.Focus();
                if (RespostaPadrao == "não")
                    A.bnt1.Focus();

                while (!A.respondido) { }
            }
            else
            {
                A.bnt1.Visible = false;
                A.bnt1.Enabled = false;

                A.bnt2.Text = "OK";
                while (!A.respondido) { }
            }
            return A.resposta;
            A.Close();
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            Aviso A = new Aviso();
            A.resposta = false;
            A.respondido = true;
        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            Aviso A = new Aviso();
            if(A.Pergunta)
            {
                A.resposta = true;
                A.respondido = true;
            }
            else
            {
                A.Close();
            }
        }
    }
}
