string fabricante;
string modelo;
int anoFabricacao;
float valor;

Carros[] vetor = new Carros[4];

void AdcionarCarros()
{

    for (int i = 0; i < 4; i++)
    {


        Console.WriteLine("Informe o fabricante do carro");
        fabricante = Console.ReadLine();
        Console.WriteLine("modelo: ");
        modelo = Console.ReadLine();
        Console.WriteLine("ano de fabricação: ");
        anoFabricacao = int.Parse(Console.ReadLine());
        Console.WriteLine("valor: ");
        valor = float.Parse(Console.ReadLine());

        Carros c1 = new(fabricante, modelo, anoFabricacao, valor);
        vetor[i] = c1;
    }

}
void ExibirCarros(){
    for (int i = 0; i < vetor.Length; i++)
    {

        Console.WriteLine(vetor[i]);
        Console.WriteLine();

    }
}

AdcionarCarros();

ExibirCarros();
