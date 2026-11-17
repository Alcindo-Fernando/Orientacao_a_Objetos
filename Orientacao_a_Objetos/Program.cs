int x = 10;
string nome = string.Empty;
char sexo = '\0';

Pessoa p1 = new("Alcindo", 22, 'M');

//Pessoa p1 = new();
//Console.WriteLine("Informe seu nome: ");
//p1.SetNome(Console.ReadLine());
//p1.Idade = 40;
//Console.WriteLine(p1.GetNome());


//Pessoa p2 = new();

//Console.WriteLine(p1.Nome);
//Console.WriteLine(p1.Idade);
//Console.WriteLine(p1.Sexo);

Console.WriteLine(p1.ToString());


