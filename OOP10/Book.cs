using System;

namespace OOP10
{
    public class Book
    {
        private string title;
        private string author;
        private string category;
        private int releaseDate;
        private int pages;

        public void SetPages(int pages)
        {
            this.pages = pages;
        }
        public void SetReleaseDate(int year)
        {
            releaseDate = year;
        }
        public void SetCategory(string p)
        {
            category = p;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine("Title: " +title);
            Console.WriteLine("Author: " +author);
            Console.WriteLine("Category: " +category);
            Console.WriteLine("Pages: " +pages);
            Console.WriteLine("Release date: " + releaseDate);
        }
    }
}