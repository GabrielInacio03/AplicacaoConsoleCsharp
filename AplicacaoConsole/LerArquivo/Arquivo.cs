using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole.LerArquivo
{
    public class Arquivo
    {
        private static string CaminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = CaminhoArquivo() + "arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string arquivoCaminho2 = CaminhoArquivo() + "arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoCaminho2))
            {
                Ler(numeroArquivo + 1);
            }
        }
    }
}
