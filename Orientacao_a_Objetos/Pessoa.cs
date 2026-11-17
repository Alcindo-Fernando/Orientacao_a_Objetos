 public class Pessoa
{
    public string Nome;
    public int Idade;
    public char Sexo;


    public Pessoa(string nome, int idade, char sexo)
    {

        this.Nome = nome;
        this.Idade = idade;
        this.Sexo = sexo;

    }


    public void SetNome(string nome)
    {

        this.Nome = nome;
        
    }

    public string GetNome()
    {
        return this.Nome;
    }


    public override string ToString()
    {
        return $"Nome: {this.Nome} \nIdade: {this.Idade} \nSexo: {this.Sexo}";
    }

}

