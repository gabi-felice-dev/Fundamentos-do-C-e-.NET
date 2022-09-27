using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);
        }

        public static void DrawScreen()
        {
            DesenhaColunas();

            for(int lines = 0; lines <= 10; lines++)
            {
                Console.Write("\n|");

                for(int col = 0; col <= 38; col++)
                   Console.Write(" ");

                Console.Write("|");
            }

            DesenhaColunas();
           
        }

        public static void DesenhaColunas()
        {
            Console.Write("\n+");
            for(int col = 0; col <= 38; col++)
                Console.Write("-");

            Console.Write("+");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 0);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 8);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOptions(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0); break;
                    }
                default: Show(); break;
            }
        }
    }
}