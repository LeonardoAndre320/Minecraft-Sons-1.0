using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Minecraft_Sons_1._0
{
    class FuncaoExtra
    {
        public string[,] LerTextura(string Local)
        {
            //Nome//Tipo//Local
            string[,] Dados = new string[1,1];

            #region Vendo se os arquivos existem
            Dados[0, 0] = "s";Dados[0, 1] = "s";
            if (!Directory.Exists(Local + "//assets//minecraft//sounds"))
            {
                Dados[0,0] = "n";
            }
            if (!File.Exists(Local + "//assets//minecraft//sounds.json"))
            {
                Dados[0, 1] = "n";
                LerJson(Local + "//assets//minecraft//sounds.json");
            }
            #endregion

            return Dados;
        }

        private string[,] LerJson(string LocalJson)
        {
            string[] Jsoni = File.ReadAllLines(LocalJson);//Lê todos as linhas
            List<string> Json = new List<string>(Jsoni);//Converte para editar mais facil

            Json.Remove("{");//remove para ficar só os dados
            Json.Remove("}");

            

            return null;
        }
    }
}
