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
        public static void Carregar(int Inicio, int Final)//Barra 400x10
        {
            Carregando c = new Carregando();
            /// 50 - 100
            /// 20 - x
            ///
            c.ShowDialog();
            c.Porcentagem = Inicio * 100 / Final;
            c.lblPorcentos.Text = "Carregando:" + c.Porcentagem + "%";
            c.Barra.Value = c.Porcentagem;

            if(c.Porcentagem >= 100) { c.Close(); }
        }
    }
}
