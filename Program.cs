using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Numbers n1 = new Numbers(3, 4);
            Console.WriteLine("3 + 4 = " + n1.add());
        }
    }
}
