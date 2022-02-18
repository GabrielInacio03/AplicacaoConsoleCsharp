using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole.LerArquivo
{
    public class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\Users\02471\Documents\arquivos\arq" + numeroArquivo + ".txt";
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

            string arquivoCaminho2 = @"C:\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoCaminho2))
            {
                Ler(numeroArquivo + 1);
            }
        }
    }
}
