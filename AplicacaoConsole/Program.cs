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

            //var cliente = new Cliente();
            //cliente.Nome = "João";
            //cliente.Telefone = "124444123";
            //cliente.Cpf = "2343920";

            //cliente.Gravar();

            Console.ReadLine();
        }
    }
}
