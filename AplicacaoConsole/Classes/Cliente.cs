using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public Cliente() { } //construtor vazio - padrão
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        public void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);

            if (File.Exists(CaminhoBaseClientes()))
            {
                string conteudo = "nome;telefone;cpf;"
                +"\n";
                foreach (Cliente c in clientes)
                {
                    conteudo += c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";\n";
                }
                File.WriteAllText(CaminhoBaseClientes(), conteudo);
            }
        }
        private static string CaminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["base_dos_clientes"];
        }
        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(CaminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');
                        var cliente = new Cliente { Nome = clienteArquivo[0], Telefone = clienteArquivo[1], Cpf = clienteArquivo[2] };
                     
                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }
    }
}
