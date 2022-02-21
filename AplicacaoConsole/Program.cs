using AplicacaoConsole.Calculo;
using AplicacaoConsole.Classes;
using AplicacaoConsole.LerArquivo;
using AplicacaoConsole.LerTabuada;
using AplicacaoConsole.Tela;
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
        static void Main(string[] args)
        {
            //Menu.Monstrar();
            var clientes = Cliente.LerClientes();
            foreach (var item in clientes)
            {
                Console.WriteLine(item.Nome +" | "+ item.Telefone +" | "+ item.Cpf);
            }

            Cliente cliente2 = new Cliente("Guilherme","93489843", "2342289");

            Console.WriteLine();
            Console.WriteLine("Testando nosso construtor: ");

            Console.WriteLine(cliente2.Nome +" - "+ cliente2.Telefone +" - "+ cliente2.Cpf);

            Console.ReadLine();
        }
    }
}
