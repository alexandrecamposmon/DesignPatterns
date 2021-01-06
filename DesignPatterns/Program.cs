using DesignPatterns.Abstract_Factory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo(a) à cozinha do Alexandre!");
            Console.WriteLine("************************************");
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Factory Method");
            Console.WriteLine("3 - Singleton");

            var opcao = Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("***********************************");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                    break;
                default:
                    break;
            }

        }
    }
}
