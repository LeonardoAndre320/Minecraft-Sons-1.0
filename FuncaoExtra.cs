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
            //0   //1   //2    //3
            //Nome//Tipo//Local//original
            Local = Path.GetDirectoryName(Local);//muda para a pasta do arquivo
            string[] Json = File.ReadAllLines(Local + "\\assets\\minecraft\\sounds.json");
            string[,] DadosJson = new string[1000,1000];
            string[,] Dados = new string[3,4];
            bool Erro = false;

            #region Vendo se os arquivos existem e se é o arquivo esperado
            Dados[0, 0] = "s";Dados[0, 1] = "s";
            if (!File.Exists(Local + "\\assets\\minecraft\\sounds.json"))
            {
                Dados[0, 0] = "n";
                Erro = true;
            } else
            if (!Directory.Exists(Local + "\\assets\\minecraft\\sounds"))
            {
                Dados[0, 1] = "n";
                Erro = true;
            } else
            if (Json.Count() % 2 != 0)
            {
                Dados[0, 2] = "n";
                Erro = true;
            } else
            if (Json[0] != "{")
            {
                Dados[0, 2] = "n";
                Erro = true;
            } else
            if (Json[Json.Count() - 1] != "}")
            {
                Dados[0, 2] = "n";
                Erro = true;
            }
            #endregion

            if (Erro == false)
            {
                string[,] DadosTemporarios = LerJson(Local + "\\assets\\minecraft\\sounds.json");
                DadosJson = new string[DadosTemporarios.Length,3];
                DadosJson = DadosTemporarios;
                //Nome//Tipo
            }

            #region Obtem o nome e o local de todos os sons da textura
            List<string> LocalTodosSons = new List<string>(Directory.GetFiles(Local + "\\assets\\minecraft\\sounds"));
            List<string> NomesSons = new List<string>(LocalTodosSons.Count);

            for(int i = 0; i< LocalTodosSons.Count; i++)//Tira so o nome dos locais
            {
                NomesSons.Add(Path.GetFileNameWithoutExtension(LocalTodosSons[i]));
            }
            #endregion

            #region Define e organiza os dados no array

            bool completo = false;
            int NumeroDados = 1;
            int Numero = 0;
            for(int etapa = 0;!completo;etapa++)
            {
                String NomeJson = DadosJson[Numero, 0];
                String TipoJson = DadosJson[Numero, 1];
                String NomeArquivo = NomesSons[etapa];
                String LocalArquivo = LocalTodosSons[etapa];

                if(NomeJson == NomeArquivo)
                {
                    Dados[NumeroDados, 0] = NomeJson;
                    Dados[NumeroDados, 1] = TipoJson;
                    Dados[NumeroDados, 2] = LocalArquivo;
                    Dados[NumeroDados, 3] = "Original";
                }
                if(etapa == NomesSons.Count)
                {
                    Numero++;
                }

                if (etapa == NomesSons.Count && Numero == DadosJson.Length)
                {
                    completo = true;
                }
            }
            MessageBox.Show("Agora vai");
            #endregion

            return Dados;
        }

        private string[,] LerJson(string LocalJson)
        {
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

            /*for(int i = 0; i < Parte1.Count; i++)
            {
                MessageBox.Show(Parte1[i] + "[----]" + Parte2[i]);
            }*/

            string[,] Retorno = new string[Parte1.Count,2];

            for(int i = 0; i < Parte1.Count;i++)
            {
                Retorno[i, 0] = Parte1[i];
                Retorno[i, 1] = Parte2[i];
            }
            return Retorno;
        }
    }
}
