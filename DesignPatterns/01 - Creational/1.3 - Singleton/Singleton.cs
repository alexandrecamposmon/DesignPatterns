using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        public static void Executar()
        {
            var livro1 = Biblioteca.GetBiblioteca();
            var livro2 = Biblioteca.GetBiblioteca();
            var livro3 = Biblioteca.GetBiblioteca();
            var livro4 = Biblioteca.GetBiblioteca();

            if (livro1 == livro2 && livro2 == livro3 && livro3 == livro4)
            {
                Console.WriteLine("Mesma instância\n");
            }

            var biblioteca = Biblioteca.GetBiblioteca();

            for(int i = 0; i < 10; i++)
            {
                var nomeLivro = biblioteca.ProximoLivro.Nome;
                Console.WriteLine("Pegando o livro: " + nomeLivro);
            }
        }

    }
}
