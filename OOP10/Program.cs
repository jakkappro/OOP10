using System;

namespace OOP10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();

            LOTR.SetTitle("Tities");
            LOTR.SetPages(1);
            LOTR.SetCategory("Eroticke");
            LOTR.SetReleaseDate(2021);
            LOTR.SetAuthor("Kubino");
            
            LOTR.Show();
        }
    }
}