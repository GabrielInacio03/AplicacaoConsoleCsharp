using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole.LerTabuada
{
    public class Tabuada
    {
        public static void MonstrarTabuada(int num)
        {
            for (int cont = 0; cont <= 10; cont++)
            {
                Console.WriteLine(num + " X " + cont + " = " + (num * cont));
            }
        }
    }
}
