using System;
using MyLibrary.Types;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVar = new MyType("Charge quality put for serious.");
            Console.WriteLine($"Value is {myVar.Value}");
            Console.WriteLine($"ValueLength is {myVar.Length}");
        }
    }
}
