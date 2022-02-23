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

            int[] ArrayInt = { 1, 2, 3, 4, 5, };

            FindMax<int> findInt = new FindMax<int>();
            findInt.MaxValue(ArrayInt);
            findInt.toPrint();
        }
    }
}
