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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal(List<string> DadosProjeto = null,string[,] Dados = null)
        {
            InitializeComponent();

            Carregar.Fechar();
            FuncaoExtra FuncaoExtra = new FuncaoExtra();
            CaixaLista.Items.Clear();
            for(int i = 1; i < FuncaoExtra.TamanhoArray(Dados);i++)
            {
                CaixaLista.Items.Add(Dados[i, 0]);
            }
        }
    }
}
