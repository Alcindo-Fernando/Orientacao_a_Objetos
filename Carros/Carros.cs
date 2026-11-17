
public class Carros
{

    public string Fabricante, Modelo;
    int AnoFabricacao;
    float Valor;


    public Carros(string fabricante, string modelo, int anoFabricacao, float valor)
    {
        this.AnoFabricacao = anoFabricacao;
        this.Fabricante = fabricante;
        this.Modelo = modelo;
        this.Valor = valor;
    }

    public override string ToString()
    {
        return $"fabricante: {Fabricante} \nModelo: {Modelo} \nAno:{AnoFabricacao} \nValor: {Valor}";
    }

}