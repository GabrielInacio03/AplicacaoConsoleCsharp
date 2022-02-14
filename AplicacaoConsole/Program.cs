using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole
{
    class Program
    {
        public const int SAIDA_PROGRAMA = 0;
        /*        
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        */
        public static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\Users\02471\Documents\arquivos\arq" + numeroArquivo +".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using(StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string arquivoCaminho2 = @"C:\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoCaminho2))
            {
                LerArquivo(numeroArquivo + 1);
            }
        }
        public static void Tabuada(int num)
        {
            for (int cont=0; cont <= 10; cont++)
            {
                Console.WriteLine(num +" X "+ cont +" = "+ (num * cont));
            }
        }
        public static void CalcularMediaAluno()
        {
            int qtdNotas = 3;

            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe as "+ qtdNotas +" notas do alunos");
            List<int> notas = new List<int>();

            for(int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota "+ i);
                notas.Add(int.Parse(Console.ReadLine()));
                
            }

            int mediaAluno = notas.Sum() / qtdNotas;

            Console.WriteLine("A média final do aluno "+ nome +" é "+ mediaAluno);

        }
        public static void Menu()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem-vindo ao program, utilizando programação funcional" +
                    "\nDigite uma das opções abaixo:" +
                    "\n0 - Sair do Programa" +
                    "\n1 - Para Ler Arquivos" +
                    "\n2 - Para Executar a Tabuada" +
                    "\n3 - Para Calcular Média de alunos";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("========== Opção Ler Arquivo ==========");

                        int numeroArquivo = int.Parse(Console.ReadLine());
                        LerArquivo(numeroArquivo);
                        Console.WriteLine("==================================================");

                        break;
                    case 2:
                        Console.WriteLine("========== Opção Tabuada ==========");

                        Console.WriteLine("Digite o número que deseja fazer a tabuada");
                        int numero = int.Parse(Console.ReadLine());

                        Tabuada(numero);
                        Console.WriteLine("==================================================");

                        break;
                    case 3:
                        Console.WriteLine("========== Opção Calcular Média ==========");

                        CalcularMediaAluno();
                        Console.WriteLine("==================================================");

                        break;
                    default:
                        Console.WriteLine("A opção digitada não é válida");
                        break;
                }

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
