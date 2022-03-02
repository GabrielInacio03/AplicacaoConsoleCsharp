using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole.Classes
{
    public class Usuario : Cliente
    {
        public Usuario() { } //construtor vazio - padrão
        public Usuario(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }
        public void Gravar()
        {
            this.Olhar();

            var usuarios = Usuario.LerUsuarios();
            usuarios.Add((Usuario)this);

            if (File.Exists(CaminhoBaseUsuarios()))
            {
                StreamWriter r = new StreamWriter(CaminhoBaseUsuarios());
                r.WriteLine("nome;telefone;cpf");

                foreach (Usuario c in usuarios)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
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
                    while ((linha = arquivo.ReadLine()) != null)
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
        private void Olhar()
        {
            Console.WriteLine("O cliente " + this.Nome + " " + this.SobreNome + " está olhando para mim");
        }
    }
}
