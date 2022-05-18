using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение заменяет во фразе К33р С4lm все символы '3' на 'e' и все '4' на 'а'

            string name = "K33p C4lm";

            string updatedname = name.Replace("3", "e");
            updatedname = updatedname.Replace("4", "a");

            Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine("this is");
            Console.WriteLine();
            Console.WriteLine(updatedname);
            

        }
    }
}
