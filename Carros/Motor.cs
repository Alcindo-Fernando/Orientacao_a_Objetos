public class Motor
{

    string Combustivel;
    int Cilindrada;
    int Potencia;

    public Motor(string combustivel, int cilindrada, int potencia)
    {

        this.Cilindrada = cilindrada;
        this.Combustivel = combustivel;
        this.Potencia = potencia;

    }


    public override string ToString()
    {
        return $"Combustível: {this.Combustivel} \nCilindradas: {this.Cilindrada} \nPotência: {this.Potencia}";
    }

}
