using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Oque deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Seleciona uma opção acima: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
                
            }

        }

        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Primerio valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1 + v2;
            Console.WriteLine($"O Resultado da Soma é: {resultado}");

            Console.ReadKey();

            Menu();

        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primerio valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = v1 - v2;

            Console.WriteLine($"O Resultado da Subtracao: {resultado}");

            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {

            Console.Clear();

            Console.WriteLine("Primerio valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = v1 / v2;

            Console.WriteLine($"O Resultado da Divisao é: {resultado}");

            Console.ReadKey();

            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primerio valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = v1 * v2;

            Console.WriteLine($"O Resultado da Multiplicacao é: {resultado}");

            Console.ReadKey();

            Menu();
        }

    }
}