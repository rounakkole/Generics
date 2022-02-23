// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Generics");
            FindMax findMax = new FindMax();
            Console.WriteLine(findMax.MaxValue<int>(40,20,10)); 
            Console.WriteLine(findMax.MaxValue<float>(30.6F, 40.2F, 10.7F));  
            Console.WriteLine(findMax.MaxValue<string>("e","h","u"));  

        }
    }
}
