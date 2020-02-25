using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;//Só pra usar o messageBox

namespace Minecraft_Sons_1._0
{
    class FuncaoExtra
    {
        public string[,] LerTextura(string Local)
        {
            //Nome//Tipo//Local
            string[,] Dados = new string[2,2];

            #region Vendo se os arquivos existem
            Dados[0, 0] = "s";Dados[0, 1] = "s";
            if (!Directory.Exists(Local + "//assets//minecraft//sounds"))
            {
                Dados[0,0] = "n";
                //return Dados;
            }
            if (!File.Exists(Local + "//assets//minecraft//sounds.json"))
            {
                Dados[0, 1] = "n";
                //return Dados;
            }
            #endregion
            MessageBox.Show("aqui");
            LerJson(Path.GetDirectoryName(Local) + "//assets//minecraft//sounds.json");
            return Dados;
        }

        private string[,] LerJson(string LocalJson)
        {
            string[,] Retorno = new string[2,2];
            string[] Jsoni = File.ReadAllLines(LocalJson);//Lê todos as linhas
            List<string> Json = new List<string>(Jsoni);//Converte para editar mais facil

            Json.Remove("{");//remove para ficar só os dados
            Json.Remove("}");

            List<string> Parte1 = new List<string>();//Local aond ficam os dados completos
            List<string> Parte2 = new List<string>();

            for(int i = 0; i < Json.Count;i = i + 2)
            {
                string P1 = Json[i];
                string P2 = Json[i + 1];

                P1 = (P1.Substring(1));//Remove tudo menos os dados
                P1 = P1.Remove(P1.Count() - 3);

                P2 = (P2.Substring(49 + P1.Count()));
                string LetraT = P2[P2.Count() - 1].ToString();//pera a ultima letra
                if(LetraT == ",")
                {
                    P2 = P2.Remove(P2.Count() - 3);
                }
                else//Muda a coleta dependendo da virgula final
                {
                    P2 = P2.Remove(P2.Count() - 2);
                }

                Parte1.Add(P1);
                Parte2.Add(P2);
            }
            //MessageBox.Show(Parte1[0] + "888" + Parte2[0]);

            for(int i = 0; i < Parte1.Count; i++)
            {
                MessageBox.Show(Parte1[i] + "" + Parte2[i]);
            }
            return Retorno;
        }
    }
}
