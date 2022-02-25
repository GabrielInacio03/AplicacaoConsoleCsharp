using AplicacaoConsole.Calculo;
using AplicacaoConsole.LerArquivo;
using AplicacaoConsole.LerTabuada;
using AplicacaoConsole.Tela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole.Tela
{
    public class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int CADASTRAR_CLIENTES = 1;
      
        public static void Monstrar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem-vindo ao program, utilizando programação funcional" +
                    "\nDigite uma das opções abaixo:" +
                    "\n0 - Sair do Programa" +
                    "\n1 - Para Ler Arquivos" +
                    "\n2 - Para Executar a Tabuada" +
                    "\n3 - Para Calcular Média de alunos" +
                    "\n4 - Cadastrar Clientes" +
                    "\n5 - Cadastrar Usuários";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("========== Opção Ler Arquivo ==========");

                        int numeroArquivo = int.Parse(Console.ReadLine());
                        Arquivo.Ler(numeroArquivo);
                        Console.WriteLine("==================================================");

                        break;
                    case 2:
                        Console.WriteLine("========== Opção Tabuada ==========");

                        Console.WriteLine("Digite o número que deseja fazer a tabuada");
                        int numero = int.Parse(Console.ReadLine());

                        Tabuada.MonstrarTabuada(numero);

                        Console.WriteLine("==================================================");

                        break;
                    case 3:
                        Console.WriteLine("========== Opção Calcular Média ==========");

                        Media.Aluno();

                        Console.WriteLine("==================================================");

                        break;
                    case 4:
                        Console.WriteLine("========== Cadastro de Clientes ==========");

                        TelaCliente.Chamar();
                        break;
                    case 5:
                        Console.WriteLine("========== Cadastro de Usuários ==========");
                        TelaUsuario.Chamar();
                        break;
                    default:
                        Console.WriteLine("A opção digitada não é válida");                        
                        Console.WriteLine("==================================================");
                        break;
                }

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                } 
            }
        }
    }
}
