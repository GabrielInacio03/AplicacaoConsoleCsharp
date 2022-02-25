using AplicacaoConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole.Tela
{
    public class TelaUsuario
    {
        public static void Chamar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem-vindo ao program, utilizando programação funcional" +
                    "\nFaça o cadastro ou a listagem do usuário" +
                    "\n0 - Sair do Cadastro" +
                    "\n1 - Cadastrar Usuário" +
                    "\n2 - Listar Usuários";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                if(valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    // cadastrar o usuário
                    Console.WriteLine("Cadastrando...");

                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Telefone: ");
                    string telefone = Console.ReadLine();
                    Console.WriteLine("Cpf: ");
                    string cpf = Console.ReadLine();

                    var gravando = new Usuario { Nome = nome, Telefone = telefone, Cpf = cpf };
                    gravando.Gravar();
                } 
                else if (valor == 2)
                {
                    // listar usuários
                    var usuarios = Usuario.LerUsuarios();
                    foreach (var item in usuarios)
                    {
                        Console.WriteLine(item.Nome + " | " + item.Telefone + " | " + item.Cpf);

                    }
                }
            }
        }
    }
}
