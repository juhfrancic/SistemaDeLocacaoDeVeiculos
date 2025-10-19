using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros
{
    public class Carro : Veiculo
    {
        public int Cavalos { get; set; }
        public int QuantidadeAssentos { get; set; }

        public Carro(string modelo, string placa, float precoDia, string marca, int cavalos, int qntAssentos)
            : base(modelo, placa, precoDia, marca)
        {
            this.Cavalos = cavalos;
            this.QuantidadeAssentos = qntAssentos;
        }
        public override void exibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Preço por dia: {PrecoDia:2F}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Cavalos: {Cavalos}");
            Console.WriteLine($"Quantidade assentos: {QuantidadeAssentos}");
        }
    }
}

