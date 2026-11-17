
public class Livro
{

    public string Titulo, Autor;
    public int Paginas;


    public Livro(string titulo, string autor, int paginas)
    {

        SetTitulo(titulo);
        SetAutor(autor);
        SetPaginas(paginas);

    }

    public Livro()
    {

    }



    public void SetTitulo(string titulo)
    {
        this.Titulo = titulo;
    }

    public void SetAutor(string autor)
    {
        this.Autor = autor;
    }

    public bool SetPaginas(int paginas)
    {
        if (paginas < 1)
        {
            Console.WriteLine($"numero de paginas do livro {this.Titulo} não pode ser menor ou igual a zero");
            
            return true;
        }
        else
        {
            this.Paginas = paginas;
            return false;
        }    

    }


    public string GetTitulo()
    {
        return this.Titulo;
    }

    public string GetAutor()
    {
        return this.Autor;
    }

    public int GetPaginas()
    {
        return this.Paginas;
    }


    public override string ToString()
    {
        return $"Titulo: {this.Titulo} \nAutor: {this.Autor} \nNº de Páginas: {this.Paginas}";
    }


    public void CriarLivro()
    {
        string titulo;
        string autor;
        int paginas;
        

        Console.Write("Digite o Titulo do Livro: ");
        SetTitulo(Console.ReadLine());

        Console.Write("Digite o nome do autor: ");
        SetAutor(Console.ReadLine());

        do
        {
            Console.Write("Digite o número de páginas: ");

        } while (SetPaginas(int.Parse(Console.ReadLine())));


    }


}

