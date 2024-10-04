using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise
{
    internal class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public Book()
        {

        }
        public Book(string author, string name, int pages)
        {
            Author = author;
            Name = name;
            Pages = pages;
        }
        public void Print()
        {
            //Ex.  J. K. Rowling, Harry Potter and the Sorcerer's Stone, 223 page
            Console.WriteLine($"{Author}, {Name}, {Pages} pages");
        }
    }

}

