using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu(){
 
            Console.Clear();
            Console.WriteLine($"\r\n Bem-vindo! \r\n  \r\n Digite a opção desejada: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine($"\r\n Digite uma opção: ");

            short res = short.Parse(Console.ReadLine());
            
            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }
            
        }

        static void Sair()
        {
            Console.WriteLine("\r\n Obrigado por utilizar o sistema...");
            System.Environment.Exit(0);
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"\r\n O resultado da divisão é: {v1 / v2}. \r\n");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"\r\n O resultado da subtração é: {v1 - v2}. \r\n");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"\r\n O resultado da multiplicação é: {v1 * v2}. \r\n");
            Console.ReadKey();
            Menu();
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"\r\n O resultado da soma é: {v1 + v2}. \r\n");
            Console.ReadKey();
            Menu();
        }
    }
}