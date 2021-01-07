using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public sealed class Biblioteca
    {
        private static readonly Biblioteca Instance = new Biblioteca();

        private readonly List<Livro> _livros;
        private readonly Random _random = new Random();

        private Biblioteca()
        {
            _livros = new List<Livro>
            {
                new Livro{Nome = "Refatoração", Autor = "Martin Fowler" },
                new Livro{Nome = "Clean Code", Autor = "Robert Martin" },
                new Livro{Nome = "DDD", Autor = "Eric Evans" },
                new Livro{Nome = "Padrões de Projetos", Autor = "Erich Gamma" }
            };
        }
        
        public static Biblioteca GetBiblioteca()
        {
            return Instance;
        }
        public Livro ProximoLivro
        {
            get 
            {
                var r = _random.Next(_livros.Count);
                return _livros[r];
            }
        }

    }
}
