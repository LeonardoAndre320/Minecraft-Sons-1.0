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
            Pontos.Value = 50;
            temporizador.Enabled = true;
        }
        public int Etapas;
        public int Total;
        private void Carregar()//Barra 400x10
        {
            ///Calculo para eu lebrar de como se faz conta de porcentagem
            /// 50 - 100
            /// 20 - x
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (Etapas != 0)
            {
                Pontos.Maximum = Total;
                Pontos.Value = Etapas;

                lblPorcentos.Text = "Carregando:" + Etapas * 100 / Total + "%";

                if (Pontos.Value == Pontos.Maximum)
                {
                    temporizador.Enabled = false;
                    Hide();
                }
            }
        }
    }
}
