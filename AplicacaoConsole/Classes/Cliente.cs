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

        public void Gravar()
        {
            this.Olhar();

            if (this.GetType() == typeof(Cliente))
            {
                var clientes = Cliente.LerClientes();
                clientes.Add(this);

                if (File.Exists(CaminhoBaseClientes()))
                {
                    string conteudo = "nome;telefone;cpf;"
                    + "\n";
                    foreach (Cliente c in clientes)
                    {
                        conteudo += c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";\n";
                    }
                    File.WriteAllText(CaminhoBaseClientes(), conteudo);
                }
            }
            else
            {
                var usuarios = Usuario.LerClientes();
                usuarios.Add(this);

                if (File.Exists(CaminhoBaseUsuarios()))
                {
                    string conteudo = "nome;telefone;cpf;"
                    + "\n";
                    foreach (Usuario c in usuarios)
                    {
                        conteudo += c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";\n";
                    }
                    File.WriteAllText(CaminhoBaseUsuarios(), conteudo);
                }
            }
            
        }
        private void Olhar()
        {
            Console.WriteLine("O cliente "+ this.Nome +" "+ this.SobreNome +" está olhando para mim");
        }
        private static string CaminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["base_dos_clientes"];
        }
        private static string CaminhoBaseUsuarios()
        {
            return ConfigurationManager.AppSettings["base_dos_usuarios"];
        }
        public static List<Usuario> LerUsuarios()
        {
            var usuarios = new List<Usuario>();
            if (File.Exists(CaminhoBaseUsuarios()))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoBaseUsuarios()))
                {
                    string linha;
                    int i = 0;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var usuarioArquivo = linha.Split(';');
                        var usuario = new Usuario { Nome = usuarioArquivo[0], Telefone = usuarioArquivo[1], Cpf = usuarioArquivo[2] };

                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
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
