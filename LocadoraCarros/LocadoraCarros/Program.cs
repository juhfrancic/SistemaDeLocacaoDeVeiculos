// See https://aka.ms/new-console-template for more information
using LocadoraCarros;

List<Veiculo> veiculos = new List<Veiculo>();

void PedirDadosGeral(out string modelo, out string placa, out float precoDia, out string marca)
{
    Console.WriteLine("Digite o modelo do veiculo: ");
    modelo = Console.ReadLine();
    Console.WriteLine("Digite a placa do veiculo: ");
    placa = Console.ReadLine();
    Console.WriteLine("Digite o preço da diária do veiculo: ");
    precoDia = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite a marca do veiculo: ");
    marca = Console.ReadLine();
}

void AdicionarCarro(List<Veiculo> veiculos)
{
    string modelo, placa, marca;
    float precoDia;

    PedirDadosGeral(out modelo, out placa, out precoDia, out marca);
    Console.WriteLine("Digite a quantidade de cavalos do carro: ");
    int cavalos = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de assentos do carro: ");
    int qntAssentos = int.Parse(Console.ReadLine());

    Carro carro = new Carro(modelo, placa, precoDia, marca, cavalos, qntAssentos);
    veiculos.Add(carro);

    Console.WriteLine("Carro adicionado!");
}
void AdicionarMoto(List<Veiculo> veiculos)
{
    string modelo, placa, marca;
    float precoDia;

    PedirDadosGeral(out modelo, out placa, out precoDia, out marca);
    Console.WriteLine("Digite a cilindrada da moto: ");
    int cilindrada = int.Parse(Console.ReadLine());

    Moto moto = new Moto(modelo, placa, precoDia, marca, cilindrada);
    veiculos.Add(moto);

    Console.WriteLine("Moto adicionada!");
}

void AdicionarCaminhao(List<Veiculo> veiculos)
{
    string modelo, placa, marca;
    float precoDia;

    PedirDadosGeral(out modelo, out placa, out precoDia, out marca);
    Console.WriteLine("Digite o numero de eixos do caminhão: ");
    int numEixos = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a capacidade do caminhão: ");
    float capacidade = int.Parse(Console.ReadLine());

    Caminhao caminhao = new Caminhao(modelo, placa, precoDia, marca, numEixos, capacidade);
    veiculos.Add(caminhao);

    Console.WriteLine("Caminhão adicionado!");
}

Pessoa CadastrarPessoa()
{
    Console.WriteLine("Escreva o nome do(a) cliente: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Escreva o CPF do(a) cliente: ");
    string cpf = Console.ReadLine();
    Console.WriteLine("Escreva o Telefone do(a) cliente: ");
    string telefone = Console.ReadLine();

    Pessoa pessoa = new Pessoa(nome, cpf, telefone);
    return pessoa;
}

float calcularLocacao(float precoDia)
{
    Console.WriteLine("Digite a quantidade de dias que vai alocar: ");
    int dias = int.Parse(Console.ReadLine());

    return precoDia * dias;
}


Console.WriteLine("Escolha a opção de veiculo que deseja alocar: ");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("  1. Carro");
Console.WriteLine("  2. Moto");
Console.WriteLine("  3. Caminhão");
Console.WriteLine("---------------------------------------------");
int opcao = int.Parse(Console.ReadLine());



switch (opcao)
{
    case 1:
        AdicionarCarro(veiculos);
        break;
    case 2:
        AdicionarMoto(veiculos);
        break;
    case 3:
        AdicionarCaminhao(veiculos);
        break;
    default:
        Console.WriteLine("Opção inválida, escolha outra!");
        break;

}
Veiculo veiculo = veiculos.Last();
float valorTotal = calcularLocacao(veiculo.PrecoDia);

Pessoa cliente = CadastrarPessoa();
Console.WriteLine();
Console.WriteLine("Dados do cliente: ");
Console.WriteLine("---------------------------------");
cliente.exibirCliente();
Console.WriteLine("---------------------------------");
Console.WriteLine();
Console.WriteLine("Dados do veículo: ");
Console.WriteLine("---------------------------------");
veiculo.exibirInformacoes();
Console.WriteLine("---------------------------------");
Console.WriteLine();
Console.WriteLine("Valor total: ");
Console.WriteLine("---------------------------------");
Console.WriteLine($"O valor total da locação é: {valorTotal}");
Console.WriteLine("---------------------------------");


