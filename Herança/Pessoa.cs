public abstract class Pessoa
{

    public string Nome { get; set; }
    public string Endereco { get; set; }

    public DateOnly Data { get; set; }

    public string Phone { get; set; }

    public Pessoa(string n)
    {
        Nome = n;

        Data = DateOnly.FromDateTime(DateTime.Now);
    }


    public override string ToString()
    {
        return $"""
            Nome: {this.Nome}
            Data de Criação: {this.Data}
            Telefone: {this.Phone}
            
            """;
    }

}

