using System;

namespace OOP10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();

            LOTR.title = "Tities";

            Console.WriteLine(LOTR.title);
        }
    }
}