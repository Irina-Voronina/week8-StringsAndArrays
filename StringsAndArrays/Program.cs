using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string someString = "Irina";
            //int stringLength = someString.Length;
            //Console.WriteLine(stringLength);


            //Задание 1
            //Приложение просит пользователя ввести имя и приложение показывает, сколько букв в имени пользователя.


            Console.WriteLine("Enter your name:");

            string name = Console.ReadLine();
            int stringLength = name.Length;

            Console.WriteLine($"Your name has {stringLength} characters!");
            Console.WriteLine();
            Console.WriteLine("Have a nice day!");


        }
    }
}
