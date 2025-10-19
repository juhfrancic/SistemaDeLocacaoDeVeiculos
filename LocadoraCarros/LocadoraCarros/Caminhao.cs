using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros
{
    public class Caminhao : Veiculo
    {
        public int NumeroEixos { get; set; }
        public float CapacidadeCarga { get; set; }

        public Caminhao(string modelo, string placa, float precoDia, string marca, int numEixos, float capacidade)
            : base(modelo, placa, precoDia, marca)
        {
            this.NumeroEixos = numEixos;
            this.CapacidadeCarga = capacidade;
        }
        public override void exibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Preço por dia: {PrecoDia:2F}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Numero de eixos: {NumeroEixos}");
            Console.WriteLine($"Capacidade de cargas: {CapacidadeCarga}");
        }
    }
}
