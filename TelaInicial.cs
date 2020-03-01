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
using System.IO.Compression;

namespace Minecraft_Sons_1._0
{
    public partial class TelaInicial : Form
    {
        string[] Args = Environment.GetCommandLineArgs();//Pega as entradas
        public TelaInicial()
        {
            InitializeComponent();
            //ChecarRecentes();
            ImagemInicial.Image = ListaImagens.Images[0];//Coloca a imagem da caixa
        }
        Aviso Aviso = new Aviso();//Atalho para aviso

        private void bntNovo_Click(object sender, EventArgs e)
        {
            TelaPrincipal TP = new TelaPrincipal();
            TP.Show();
            Hide();
        }

        private void bntAbrir_Click(object sender, EventArgs e)
        {
            FuncaoExtra FuncaoExtra = new FuncaoExtra(); //Entenda como um using

            Buscador.Title = "Escolha o arquivo .mcmeta de sua textura ou o arquivo .zip dela";
            Buscador.Multiselect = false;
            Buscador.FileName = "";
            Buscador.Filter = "Arquivo minecraft|*.mcmeta|Arquivos ZIP|*.zip|Todos os arquivos|*.*";
            Buscador.ShowDialog();

            if (Buscador.FileName != "")
            {
                string LocalArquivo = Buscador.FileName;
                string extencao = Path.GetExtension(LocalArquivo);
                string NomeArquivo = Path.GetFileNameWithoutExtension(LocalArquivo);

                if (extencao == ".zip")
                {
                    if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Temp")) { Directory.Delete(Directory.GetCurrentDirectory() + "\\Temp", true); }//Exclui a pasta Temp
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Temp");
                    ZipFile.ExtractToDirectory(LocalArquivo, Directory.GetCurrentDirectory() + "\\Temp");
                    
                    
                }
                else if(extencao == ".mcmeta")
                {
                    if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Temp")){ Directory.Delete(Directory.GetCurrentDirectory() + "\\Temp", true); }//Exclui a pasta Temp
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Temp");
                    //MessageBox.Show(Directory.GetParent(LocalArquivo) + "");
                    FuncaoExtra.CopiarDiretorio(Directory.GetParent(LocalArquivo) + "", Directory.GetCurrentDirectory() + "\\Temp", true);
                }
                else if(extencao == "mcs")
                {
                    //Dai tem que ver como fazer
                }
                else
                {
                    Aviso.mostrar("Não conheço esse arquivo", "O arquivo que você escolheu não é nem .zip, .mcmeta ou .mcs, ele é " + extencao + ". \nEscolha novamente.", "Media");
                }
            }
        }

        public void ChecarRecentes()
        {
            if(!File.Exists(Directory.GetCurrentDirectory() + "//Recentes.txt"))
            {
                GrupoRecentes.Text = "Recentes(0)";

                lblR1.Visible = false;
                lblR2.Visible = false;
                lblR3.Visible = false;
                lblR4.Visible = false;
                lblR5.Visible = false;
                lblR6.Visible = false;
                lblR7.Visible = false;
                lblR8.Visible = false;
                lblR9.Visible = false;
                lblR10.Visible = false;
            }
        }

        public void MudarMouseE(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        public void MudarMouseS(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
