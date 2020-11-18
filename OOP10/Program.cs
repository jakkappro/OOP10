using System;

namespace OOP10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();

            LOTR.Title = "Tities";
            LOTR.Pages =1;
            LOTR.Category = "Eroticke";
            LOTR.ReleaseDate = 2021;
            LOTR.Author = "Kubino";
            
            LOTR.Show();
        }
    }
}