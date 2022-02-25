using AplicacaoConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole.Tela
{
    public class TelaCliente
    {
        public static void Chamar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem-vindo ao program, utilizando programação funcional" +
                    "\nFaça o cadastro ou a listagem do usuário" +
                    "\nDigite uma das opções abaixo:" +
                    "\n0 - Sair do Cadastro" +
                    "\n1 - Cadastrar Cliente" +
                    "\n2 - Listar Clientes";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                if(valor == 0)
                {
                    break;
                } 
                else if (valor == 1)
                {
                    // cadastrar o cliente
                    Console.WriteLine("Cadastrando...");

                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Telefone: ");
                    string telefone = Console.ReadLine();
                    Console.WriteLine("Cpf: ");
                    string cpf = Console.ReadLine();

                    var gravando = new Cliente { Nome = nome, Telefone = telefone, Cpf = cpf };
                    gravando.Gravar();
                }
                else if(valor == 2)
                {
                    // listar clientes
                    var clientes = Cliente.LerClientes();
                    foreach (var item in clientes)
                    {
                        Console.WriteLine(item.Nome + " | " + item.Telefone + " | " + item.Cpf);

                    }
                }
                else
                {
                    Console.WriteLine("Erro. Opção inválida");
                    break;
                }

                
                

                Console.WriteLine("=================================================");

            }

        }
    }
}
