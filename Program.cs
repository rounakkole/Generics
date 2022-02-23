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
            Console.WriteLine(findMax.MaxFloat(30.4F,20.8F,10.5F)); //TC 1.1
            Console.WriteLine(findMax.MaxFloat(30.6F,40.2F,10.7F));  //TC 1.1
            Console.WriteLine(findMax.MaxFloat(30.5F,20.2F,40.9F));  //TC 1.1

        }
    }
}
