using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello"; //immutable

            //string updatedHello = hello.Replace('e', '3');
            //updatedHello = updatedHello.Replace('o', '0');
            hello = hello.Replace('e', '3');
            hello = hello.Replace('o', '0');
            Console.WriteLine(hello);
            //Console.WriteLine(updatedHello);
        }
    }
}
