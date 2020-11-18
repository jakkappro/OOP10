using System;

namespace OOP10
{
    class Program
    {
        static void Main(string[] args)
        {
            var LOTR2 = new Book();
            var LOTR3 = new Book("book", 12);
            var HOBIT = new Book("hobit", 200, 1712,"never hapend", "ten najlepsi");

            HOBIT.Category = Book.categoryList[1];
            
            LOTR2.Show();
            Console.WriteLine();
            LOTR3.Show();
            Console.WriteLine();
            HOBIT.Show();
        }
    }
}