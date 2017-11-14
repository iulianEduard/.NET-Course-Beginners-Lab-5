using System;

namespace Lab5.ConsoleApp.Polymorphism
{
    public abstract class Book
        {
        public string Name { get; set; }

        public string Author { get; set; }

        public int NumberOfPages { get; set; }

        public double Rating { get; set; }

        public Book()
        {

        }

        public Book(string name, string author, int numberOfPages, double rating)
        {
            Name = name;
            Author = author;
            NumberOfPages = numberOfPages;
            Rating = rating;
        }

        public virtual void DisplayBook()
        {
            Console.WriteLine($"Select book:");
            Console.WriteLine($"{Name} by {Author}");
            Console.WriteLine($"Number of pages: {NumberOfPages}");
            Console.WriteLine($"Rating: {Rating}");
        }
    }

    public class SciFi : Book
    {
        public SciFi(string name, string author, int numberOfPages, double rating): base(name, author, numberOfPages, rating)
        {
        }

        public override void DisplayBook()
        {
            Console.WriteLine("=== Message from SciFi object ====");
            Console.WriteLine("");
            base.DisplayBook();
            Console.WriteLine("==== =====");
        }
    }

    public class Drama : Book
    {
        public Drama(string name, string author, int numberOfPages, double rating) : base(name, author, numberOfPages, rating)
        {

        }

        public void Display()
        {
            Console.WriteLine("=== Message from Drama object ====");
            Console.WriteLine($"{Name} by {Author} has {NumberOfPages} pages and a rating of {Rating}");
        }
    }
}
