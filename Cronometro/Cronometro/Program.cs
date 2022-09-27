using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\nBem-vindo");
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos > 10s");
            Console.WriteLine("M - Minutos > 1m");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower();
            if(data == "0")
                System.Environment.Exit(0);

            
            char type = char.Parse(data.Substring(data.Length -1, 1));
            int  time = int.Parse(data.Substring(0, data.Length-1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
              Console.Clear();

              Console.WriteLine("Ready...");   
              Thread.Sleep(1000); 

              Console.WriteLine("Set...");   
              Thread.Sleep(1000);

              Console.WriteLine("Go...");   
              Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);   
                Thread.Sleep(1000); 
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado :)");
             Thread.Sleep(2000); 
            Menu();
        }

       
    }
}