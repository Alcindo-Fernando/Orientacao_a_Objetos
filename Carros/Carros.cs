
public class Carros
{

    public string Fabricante, Modelo;
    int AnoFabricacao;
    float Valor;
    Motor motor;


    public Carros(string fabricante, string modelo, int anoFabricacao, float valor)
    {
        this.AnoFabricacao = anoFabricacao;
        this.Fabricante = fabricante;
        this.Modelo = modelo;
        this.Valor = valor;
    }

    public override string ToString()
    {
        return $"fabricante: {Fabricante} \nModelo: {Modelo} \nAno:{AnoFabricacao} \nValor: {Valor} \n{motor}";
    }

    public void CriarMotor()
    {
        string comb;
        int cili;
        int pote;

        Console.Write("Informe o combustível: ");
        comb = Console.ReadLine();

        Console.Write("Informe a cilindrada: ");
        cili = int.Parse(Console.ReadLine());

        Console.Write("Infrome a potencia: ");
        pote = int.Parse(Console.ReadLine());


        motor = new Motor(comb, cili, pote);
    }


    public string CalcularIPVA()
    {
        double ipva;

        if (2026 - this.AnoFabricacao < 20)
            ipva = (this.Valor * 0.04);

        else
            ipva = 0;

        return $"IPVA = R$ {ipva:F2}";

    }

}