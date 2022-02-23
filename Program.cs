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
            float[] ArrayFloat = { 30.6F, 40.2F, 10.7F };
            string[] ArrayString = { "e", "h", "u", "a", "f", "s" };


            FindMax<int> findInt = new FindMax<int>();
            Console.WriteLine(findInt.MaxValue(ArrayInt));

            FindMax<float> findFloat = new FindMax<float>();
            Console.WriteLine(findFloat.MaxValue(ArrayFloat));

            FindMax<string> findString = new FindMax<string>();
            Console.WriteLine(findString.MaxValue(ArrayString));  

        }
    }
}
