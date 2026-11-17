public class PessoaFisica : Pessoa
{

    public string CPF { get; set; }

    public string Mobile { get; set; }

    public char Gender { get; set; }

  
    public PessoaFisica(string cpf,string n) : base(n) //para construir um filho, caso o pai precise de parametro temho que trazer da base
    {

        this.CPF = cpf;

    }


    public override string ToString()
    {
        return base.ToString() + $"""
            CPF: {this.CPF}
            Celular: {this.Mobile}
            Sexo: {this.Gender}
            
            """;
    }


}