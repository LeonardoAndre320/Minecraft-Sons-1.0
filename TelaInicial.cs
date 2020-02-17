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
    public partial class TelaInicial : Form
    {
        string[] Args = Environment.GetCommandLineArgs();//Pega as entradas
        public TelaInicial()
        {
            InitializeComponent();
            ImagemInicial.Image = ListaImagens.Images[0];//Coloca a imagem da caixa
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {

        }

        private void bntAbrir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
