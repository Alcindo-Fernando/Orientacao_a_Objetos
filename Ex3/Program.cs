Livro livro1 = new("Borboletas", "José", 149);

Livro livro2 = new();

Livro[] vetLivro = new Livro[2];

vetLivro[0] = livro1;
vetLivro[1] = livro2;

livro2.CriarLivro();

for (int i = 0; i < vetLivro.Length; i++) {
    Console.WriteLine(vetLivro[i]);
    Console.WriteLine();
}





