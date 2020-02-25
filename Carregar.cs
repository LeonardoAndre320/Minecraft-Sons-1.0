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
        public Carregar()
        {
            InitializeComponent();
        }

        public static void Abrir()
        {
            Carregar c = new Carregar();
            c.Show();
        }

        public static void Fechar()
        {
            while (Application.OpenForms["Carregar"] != null)
            {
                Application.OpenForms["Carregar"].Close();
            }
        }
    }
}
