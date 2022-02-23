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
            FindMax<int> findInt = new FindMax<int>();
            Console.WriteLine(findInt.MaxValue(40,20,10));

            FindMax<float> findFloat = new FindMax<float>();
            Console.WriteLine(findFloat.MaxValue(30.6F, 40.2F, 10.7F));

            FindMax<string> findString = new FindMax<string>();
            Console.WriteLine(findString.MaxValue("e","h","u"));  

        }
    }
}
