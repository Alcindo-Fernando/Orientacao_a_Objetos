Livro livro1 = new("Borboletas", "José", 149);
Livro livro2; 

CriarLivro(out livro2);

Console.WriteLine(livro1);
Console.WriteLine();
Console.WriteLine(livro2);

void CriarLivro(out Livro livro)
{
    string titulo;
    string autor;
    int paginas;


    do
    {
        Console.Write("Digite o Titulo do Livro: ");
        titulo = Console.ReadLine();

        Console.Write("Digite o nome do autor: ");
        autor = Console.ReadLine();

        Console.Write("Digite o número de páginas: ");
        paginas = int.Parse(Console.ReadLine());


        livro = new(titulo, autor, paginas);

    } while (livro.SetPaginas(paginas));

}



