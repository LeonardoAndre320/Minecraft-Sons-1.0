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
    public partial class Carregar : Form
    {
        public int Etapa = 1;
        public int Total = 100;
        private int porcentagem;

        public Carregar()
        {
            InitializeComponent();

            Thread T = new Thread(MostrarDados);
            T.Start();
        }

        private void MostrarDados()
        {
            Show();
            while (Etapa != Total)
            {
                porcentagem = Etapa * 100 / Total;

                this.Invoke(new Action(() => lblPorcentos.Text = "Carregando:" + porcentagem + "%"));
                this.Invoke(new Action(() => Barra.Value = porcentagem));

                //lblPorcentos.Text = porcentagem + "";
                //Barra.Value = porcentagem;
            }
            this.Invoke(new Action(() => Hide()));
        }

        private void Carregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Etapa = 0;
            Total = 100;
            Barra.Value = 0;
            Hide();
        }
    }
}
