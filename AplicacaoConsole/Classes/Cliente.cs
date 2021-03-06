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
        public string SobreNome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public Cliente() { } //construtor vazio - padrão
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        public virtual void Gravar()
        {
            this.Olhar();

           
            var clientes = Cliente.Ler();
            clientes.Add(this);

            if (File.Exists(CaminhoBase()))
            {
                StreamWriter r = new StreamWriter(CaminhoBase());
                r.WriteLine("nome;telefone;cpf");

                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome +";"+ c.Telefone +";"+ c.Cpf +";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
            
           
            
        }
        public virtual void Olhar()
        {
            Console.WriteLine("O cliente "+ this.Nome +" "+ this.SobreNome +" está olhando para mim");
        }
        private static string CaminhoBase()
        {
            return ConfigurationManager.AppSettings["base_dos_clientes"];
        }        
        
        public static List<Cliente> Ler()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(CaminhoBase()))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoBase()))
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
