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
            Console.WriteLine(findMax.MaxInt(30,20,10)); //TC 1.1
            Console.WriteLine(findMax.MaxInt(30,40,10));  //TC 1.1
            Console.WriteLine(findMax.MaxInt(30,20,40));  //TC 1.1

        }
    }
}
