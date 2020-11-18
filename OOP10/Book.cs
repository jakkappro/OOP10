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

        public string Title
        {
            get => title;
            set => title = value;
        }
        public string Author 
        { 
            get => author;
            set => author = value;
        }
        public string Category 
        { 
            get => category;
            set => category = value;
        }
        public int ReleaseDate 
        { 
            get => releaseDate;
            set
            {
                if (value > 2021 || value < 1450)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }
        public int Pages 
        { 
            get => pages;
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Release date: " + releaseDate);
        }
    }
}