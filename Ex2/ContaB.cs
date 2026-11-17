public class ContaB {

    public string Titular;
    public double Saldo;



    public ContaB(string titular, double saldo)
    {
        SetTitular(titular);
        SetSaldo(saldo);
    }

    public void ExibirSaldo()
    {

        Console.WriteLine($"Olá, {Titular}");
        Console.WriteLine($"Seu saldo: R$ {Saldo:F2}");
    }

    public bool Depositar(double valor)
    {
        if (valor <= 0)
        {
            Erro();
            return true;
        }
        else
        {
            this.Saldo += valor;
            return false;
        }
    }

    public bool Sacar(double valor)
    {

        if (valor < 0)
        {
            Erro();
            return true;
        }
        else if (valor > this.Saldo)
        {
            Console.WriteLine("saldo insuficiente");
            return true;
        }
        else
        {
            this.Saldo -= valor;

            return false;
        }
        
    }

    public void Erro()
    {
        Console.WriteLine("informação preenchida errado!");
    }

    public void SetTitular(string titular)
    {
        this.Titular = titular;
    }
    
    public string GetTitular()
    {
        return this.Titular;
    }

    public void SetSaldo(double saldo)
    {
        this.Saldo = saldo;
    }
  
    public double GetSaldo()
    {
        return this.Saldo;
    }

    public override string ToString()
    {
        return $"Titular: {this.Titular} \n Saldo: R$ {this.Saldo:F2}";
    }

    public void OperarConta()
    {
        int opcao;
        double valor;
        bool sair = true;
        do
        {
            Console.WriteLine("Olá, digite uma das opções para sua conta abaixo: ");
            Console.WriteLine("1. Ver saldo");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Depositar");
            Console.WriteLine("4. Exibir dados da conta");
            Console.WriteLine("0. Sair");

            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:

                    ExibirSaldo();

                    break;

                case 2:
                    do
                    {
                        Console.WriteLine("Digite o valor que deseja sacar: ");
                        valor = double.Parse(Console.ReadLine());

                    } while (Sacar(valor));
                    break;

                case 3:

                    do
                    {

                        Console.WriteLine("Digite o valor que deseja depositar: ");
                        valor = double.Parse(Console.ReadLine());
                    } while (Depositar(valor));

                    break;


                case 4:

                    Console.WriteLine(ToString());
                    break;

                case 0:
                    sair = false;
                    break;


            }


        } while (sair);

    }

}