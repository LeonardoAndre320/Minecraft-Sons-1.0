﻿using System;
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
            Aviso Aviso = new Aviso();//Entenda isso como um using:)

            //0   //1   //2    //3
            //Nome//Tipo//Local//original
            Local = Path.GetDirectoryName(Local);//muda para a pasta do arquivo
            string[] Json = File.ReadAllLines(Local + "\\assets\\minecraft\\sounds.json");
            string[,] DadosJson = new string[100,2];
            string[,] DadosT = new string[1, 4];
            bool Erro = false;

            #region Vendo se os arquivos existem e se é o arquivo esperado
            DadosT[0, 0] = "s"; DadosT[0, 1] = "s"; DadosT[0, 2] = "s"; DadosT[0, 3] = "s";//Já define um valor, só muda se tiver algum problema
            if (!File.Exists(Local + "\\assets\\minecraft\\sounds.json"))
            {
                DadosT[0, 0] = "n";
                Erro = true;
            } else
            if (!Directory.Exists(Local + "\\assets\\minecraft\\sounds"))
            {
                DadosT[0, 1] = "n";
                Erro = true;
            } else
            if (Json.Count() % 2 != 0)
            {
                DadosT[0, 2] = "n";
                Erro = true;
            } else
            if (Json[0] != "{")
            {
                DadosT[0, 2] = "n";
                Erro = true;
            } else
            if (Json[Json.Count() - 1] != "}")
            {
                DadosT[0, 2] = "n";
                Erro = true;
            }
            #endregion

            if (Erro == false)
            {
                string[,] DadosTemporarios = LerJson(Local + "\\assets\\minecraft\\sounds.json");
                DadosJson = new string[TamanhoArray(DadosTemporarios),3];
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

            #region Verefica se exite mais de um do que de outro
            int NumeroRegistros = TamanhoArray(DadosJson);
            int NumeroArquivos = LocalTodosSons.Count;

            {

                if(NumeroRegistros > NumeroArquivos)
                {
                    Aviso.mostrar("É demais", "Tem mais registros do que arquivos, e não consigo dizer qual é qual.\nMas ainda consigo carregar uns dados.");
                }
                else
                if(NumeroRegistros < NumeroArquivos)
                {
                    Aviso.mostrar("É demais", "Tem mais arquivos do que registros e isso acabou comigo.\nMuitos arquivos confundem meus sistema e não vou poder carregar mais nada.\nVá até a pasta e exclua todos os arquivos que não forem importantes e tente novamente");
                    Erro = true;
                }
            }
            #endregion

            #region Cria a matriz que retorna os dados
            string[,] Dados = new string[NumeroRegistros + 1, 4];

            Dados[0, 0] = DadosT[0, 0];
            Dados[0, 1] = DadosT[0, 1];
            Dados[0, 2] = DadosT[0, 2];
            Dados[0, 3] = DadosT[0, 3];
            #endregion

            #region Define e organiza os dados no array
            {
                string NomeJson;
                string TipoJson;
                string NomeArquivo;//Variaveis que servem de apoio
                string LocalArquivo;
                int IntEscritura = 1; 

                for(int Etapa = 0; Etapa < TamanhoArray(DadosJson); Etapa++)
                {
                    NomeJson = DadosJson[Etapa, 0];//Recebe os primeiros dados
                    TipoJson = DadosJson[Etapa, 1];//A lista é organizada a partir disso
                    for (int i = 0;i  < NomesSons.Count;i++)
                    {
                        NomeArquivo = NomesSons[i];
                        LocalArquivo = LocalTodosSons[i];//Recebe os dados que serão procurados

                        if(NomeJson == NomeArquivo)
                        {//Se tudo estiver certo ele modifica a saida com os dados já organizados
                            Dados[IntEscritura, 0] = NomeJson;
                            Dados[IntEscritura, 1] = TipoJson;
                            Dados[IntEscritura, 2] = LocalArquivo;
                            Dados[IntEscritura, 3] = "Original";
                            IntEscritura++;
                        }
                    }
                }
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

        public int TamanhoArray(string[,] Array)
        {
            string[,] Matriz = Array;
            int Retorno = 0;

            #region Verefia se é 0
            try
            {
                Matriz[0, 0] = "";
            }catch
            {
                Retorno = 0;
            }
            #endregion

            #region Verefica qual o numero a partir do erro

            try
            {
                for(int i = 1;i<Matriz.Length;i++)
                {
                    Retorno = i;
                    Matriz[i, 0] = i + "";
                }
            }
            catch { }//Não tem nada para não parar o programa

            #endregion

            return Retorno;
        }

        public void CopiarDiretorio(string DiretorioInicial,string DiretorioFinal,bool CopiarSubdiretorios)
        {
            DirectoryInfo Diretorio = new DirectoryInfo(DiretorioInicial);

            if(Diretorio.Exists)
            {
                DirectoryInfo[] Diretorios = Diretorio.GetDirectories();//Pega todos os diretorios

                if (!Directory.Exists(DiretorioFinal))//Cria o destino se ele não existir
                {
                    Directory.CreateDirectory(DiretorioFinal);
                }

                FileInfo[] Arquivos = Diretorio.GetFiles();//Pega todos os aquivos

                foreach(FileInfo file in Arquivos)//Copia cada arquivo, eu acho
                {
                    string CaminhoTemporario = Path.Combine(DiretorioFinal, file.Name);
                    file.CopyTo(CaminhoTemporario, false);
                }

                if (CopiarSubdiretorios)
                {
                    foreach (DirectoryInfo SubDiretorio in Diretorios)//Copia todas as pastas
                    {
                        string CaminhoTemporario = Path.Combine(DiretorioFinal, SubDiretorio.Name);
                        CopiarDiretorio(SubDiretorio.FullName, CaminhoTemporario, CopiarSubdiretorios);
                    }
                }
            }
        }
        //Codigo baseado em:https://docs.microsoft.com/pt-br/dotnet/standard/io/how-to-copy-directories
    }
}
