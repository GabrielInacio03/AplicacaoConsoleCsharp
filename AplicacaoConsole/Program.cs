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
                Console.WriteLine(item.Nome + " | " + item.Telefone + " | " + item.Cpf);

            }
            var gravando = new Cliente { Nome = "Teste", Telefone = "22323232", Cpf = "224335432"};
            gravando.Gravar();
            Console.ReadLine();
        }
    }
}
