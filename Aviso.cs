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
        public bool mostrar(string Titulo, string Mensagem, string SAG = "Simples,Aviso,Grave", bool pergunta = false,string resposta = "sim/não")
        {
            lblTitulo.Text = Titulo;
            lblMensagem.Text = Mensagem;
            ShowDialog();

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

            
            
        }

        //case "simples":  A.BackColor = Color.SteelBlue; break;
        //case "media":  A.BackColor = Color.Goldenrod; break;
        //case "grave":  A.BackColor = Color.IndianRed; break;

        private void bnt1_Click(object sender, EventArgs e)
        {
         
        }

        private void bnt2_Click(object sender, EventArgs e)
        {

        }
    }
}
