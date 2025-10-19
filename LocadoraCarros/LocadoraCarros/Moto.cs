using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string modelo, string placa, float precoDia, string marca, int cilindrada)
            : base(modelo, placa, precoDia, marca)
        {
            this.Cilindrada = cilindrada;
        }

        public override void exibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Preço por dia: {PrecoDia:2F}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Cilindrada: {Cilindrada}");
        }
    }
}
