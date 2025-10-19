using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros
{
    public abstract class Veiculo
    {
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public float PrecoDia { get; private set; }
        public string Marca { get; private set; }

        public Veiculo(string modelo, string placa, float precoDia, string marca)
        {
            this.Modelo = modelo;
            this.Placa = placa;
            this.PrecoDia = precoDia;
            this.Marca = marca;
        }

        public abstract void exibirInformacoes();

    }
}

