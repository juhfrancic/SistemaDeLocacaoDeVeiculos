using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros
{
    internal class Pessoa
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Telefone { get; private set; }

        public Pessoa(string nome, string cpf, string telefone)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
        }

        public void exibirCliente()
        {
            Console.WriteLine($"Nome do cliente: {Nome}");
            Console.WriteLine($"CPF do cliente: {CPF}");
            Console.WriteLine($"Telefone do cliente: {Telefone}");
        }

    }
}
