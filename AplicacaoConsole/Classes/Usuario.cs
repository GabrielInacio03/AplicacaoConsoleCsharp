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
        //new -> força a sobreescrita
        //override -> sobreescreve
        //sealed -> a classe no pode ser sobreescrita
        public override void Gravar()
        {
            this.Olhar();

            var usuarios = Usuario.Ler();
            usuarios.Add((Usuario)this);

            if (File.Exists(CaminhoBase()))
            {
                StreamWriter r = new StreamWriter(CaminhoBase());
                r.WriteLine("nome;telefone;cpf");

                foreach (Usuario c in usuarios)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }
        private static string CaminhoBase()
        {
            return ConfigurationManager.AppSettings["base_dos_usuarios"];
        }
        public static List<Usuario> Ler()
        {
            var usuarios = new List<Usuario>();
            if (File.Exists(CaminhoBase()))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoBase()))
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
        public override void Olhar()
        {
            base.Olhar(); //retorna o dado original
        }
    }
}
