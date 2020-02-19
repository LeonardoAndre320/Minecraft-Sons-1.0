using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Minecraft_Sons_1._0
{
    public partial class Carregando : Form
    {

        public Carregando()
        {
            InitializeComponent();
        }
        public int Etapas;
        public int Total;
        public void Carregar()
        {
            Thread T = new Thread(new ThreadStart(MostrarDados));
            T.Name = "MostrarDados";
            T.Start();
        }

        private void MostrarDados()
        {
            ShowDialog();
            while (Etapas != Total)
            {
                Barra.Maximum = Total;
                Barra.Value = Etapas;

                lblPorcentos.Text = "Carregando:" + Etapas * 100 / Total + "%";

                if (Barra.Value == Barra.Maximum)
                {
                    Barra.Value = 0;
                    Barra.Maximum = 100;
                    Hide();
                    break;
                }
                Thread.Sleep(1000);
            }
        }
    }
}
