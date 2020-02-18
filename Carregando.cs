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
            ///Calculo para eu lebrar de como se faz conta de porcentagem
            /// 50 - 100
            /// 20 - x
            
            Porcentagem = Inicio * 100 / Final;

            lblPorcentos.Text = "Carregando:" + Porcentagem + "%";
            Barra.Value = Porcentagem;//Exibem os dados
            temporizador.Enabled = true;
            ShowDialog();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (Porcentagem >= 100)
            {
                temporizador.Enabled = false;
                Hide();//Quando termina fecha, tinha que ser em um timer, sei la o por que
            }
        }
    }
}
