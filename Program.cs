using System;
using CSharp05.Model;

namespace CSharp05
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Students();
            student1.Name="Irwin";
            student1.Surnames="Estrada";
            Console.WriteLine(student1.getFullName());
        }
    }
}
