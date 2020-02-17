using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            Buscador.Title = "Escolha o arquivo .mcmeta de sua textura ou o arquivo .zip dela";
            Buscador.Multiselect = false;
            Buscador.FileName = "";
            Buscador.Filter = "Arquivo minecraft|*.mcmeta|Arquivos ZIP|*.zip|Todos os arquivos|*.*";
            Buscador.ShowDialog();

            if (Buscador.FileName != "")
            {
                Carregando C = new Carregando();
                C.ShowDialog();

                int Tarefas = 10;

                string LocalArquivo = Buscador.FileName;
                string extencao = Path.GetExtension(LocalArquivo);
                string NomeArquivo = Path.GetFileNameWithoutExtension(LocalArquivo);

                if(extencao == ".zip")
                {
                    //extrair arquivos e remover dados a partir de uma pasta temporaria
                }
                else if(extencao == ".mcmeta")
                {
                    //remover dados a partir da pasta sem alterar nada
                }
                else
                {
                    Tarefas = 10;
                }
                Tarefas = 10 / 2;
            }
        }
    }
}
