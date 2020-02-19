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

        public static int Etapa;
        public static int Total;
        private int Porcentagem;
        public Carregando()
        {
            InitializeComponent();
        }

        public static void Carregar()//Barra 400x10
        {
            ///Calculo para eu lebrar de como se faz conta de porcentagem
            /// 50 - 100
            /// 20 - x

            Carregando c = new Carregando();
            c.temporizador.Enabled = true;
            c.ShowDialog();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            Porcentagem = Etapa * 100 / Total;
            Barra.Value = Porcentagem;
            lblPorcentos.Text = "Carregando:" + Porcentagem + "%";

            if(Porcentagem >= 100) { Hide(); } 
        }
    }
}
