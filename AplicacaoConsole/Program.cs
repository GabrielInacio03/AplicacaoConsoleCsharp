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
            Menu.Monstrar();

            //teste
            Usuario u = new Usuario { Nome = "Teste", Telefone = "32223714", Cpf = "23323242"};

            u.Gravar();
            

            Console.ReadLine();
        }
    }
}
