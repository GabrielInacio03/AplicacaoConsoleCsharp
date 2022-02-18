using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole.Calculo
{
    public class Media
    {
        public static void Aluno()
        {
            int qtdNotas = 3;

            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe as " + qtdNotas + " notas do alunos");
            List<int> notas = new List<int>();

            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota " + i);
                notas.Add(int.Parse(Console.ReadLine()));

            }

            int mediaAluno = notas.Sum() / qtdNotas;

            Console.WriteLine("A média final do aluno " + nome + " é " + mediaAluno);

        }
    }
}
