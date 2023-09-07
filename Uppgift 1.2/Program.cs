using System;

namespace Uppgift_1._2
{
    class Program
    {
        static void Main(string[]args)
        {
            //Ändra bakgrundsfärg till blå
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            //Ändra textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Your PC ran into a problem that it couldn't handle, and now it needs to restart.");
            Console.ReadKey();
        }
    }
}
   
