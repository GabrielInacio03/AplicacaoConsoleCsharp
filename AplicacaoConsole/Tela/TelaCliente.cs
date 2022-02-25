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
            var clientes = Cliente.LerClientes();
            foreach (var item in clientes)
            {
                Console.WriteLine(item.Nome + " | " + item.Telefone + " | " + item.Cpf);

            }
            var gravando = new Cliente { Nome = "Teste", Telefone = "22323232", Cpf = "224335432" };
            gravando.Gravar();
        }
    }
}
