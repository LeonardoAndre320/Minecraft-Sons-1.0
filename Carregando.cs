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
    public partial class Carregando : Form
    {
        public Carregando()
        {
            InitializeComponent();
        }

        int Porcentagem;
        public void Carregar(int Inicio, int Final)//Barra 400x10
        {
            /// 50 - 100
            /// 20 - x
            ///
            Porcentagem = Inicio * 100 / Final;
            lblPorcentos.Text = "Carregando:" + Porcentagem + "%";
            Barra.Value = Porcentagem;

            if(Porcentagem >= 100) { Close(); }
        }
    }
}
