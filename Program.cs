// See https://aka.ms/new-console-template for more information
using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Generics");
            FindMax findMax = new FindMax();
            Console.WriteLine(findMax.MaxString("y","t","s")); //TC 1.1
            Console.WriteLine(findMax.MaxString("g","r","f"));  //TC 1.1
            Console.WriteLine(findMax.MaxString("e","h","u"));  //TC 1.1

        }
    }
}
