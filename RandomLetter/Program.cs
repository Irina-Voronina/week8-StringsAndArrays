using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение спрашивает у пользователя его имя и показывает случайную букву из имени пользователя

            Console.WriteLine("Enter your name:");

            string name = Console.ReadLine();
            Random rnd = new Random();
            int randomletter = rnd.Next(0, name.Length);

            Console.WriteLine($"Random letter from your name: {name[randomletter]}");

        }
    }
}
