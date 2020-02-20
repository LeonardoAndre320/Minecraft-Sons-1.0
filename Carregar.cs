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
    public partial class Carregar : Form
    {
        private delegate void ProgressoDelegate(int progresso);
        private ProgressoDelegate del;

        public int Progresso
        {
            get { return Barra.Value; }
            set { Barra.Value = value; }
        }

        public Carregar()
        {
            InitializeComponent();
            Barra.Maximum = 100;
            del = AtualizacaoProgressoInterna;
        }

        private void AtualizacaoProgressoInterna(int progresso)
        {
            if(Handle == null)
            {
                return;
            }
            Invoke(del,progresso);
        }
    }

    public class HardWorker
    {
        public event EventHandler<HardWorkerEventArgs> ProgressChanged;
        public event EventHandler HardWorkDone;
        public void doHardWork()
        {
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 500000; j++)
                {
                    Math.Pow(i, j);
                }
                OnProgressChanged(i);
            }
        }

        private void OnProgressChanged(int Progress)
        {
            var handLer = ProgressChanged;
            if (handLer != null)
            {
                handLer(this, new HardWorkerEventArgs(Progress));
            }
        }

        private void OnHardWorkDone()
        {
            var handLer = HardWorkDone;
            if (handLer != null)
            {
                handLer(this, EventArgs.Empty);
            }
        }

        public class HardWorkerEventArgs : EventArgs
        {
            public HardWorkerEventArgs(int progress)
            {
                Progress = progress;
            }
            public int Progress
            {
                get;
                private set;
            }
        }
            
    }
}
