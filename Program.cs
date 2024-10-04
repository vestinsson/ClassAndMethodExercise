using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Class and Method Exercise
Task-1:
Create a "Book" class that describes a book. Each book has an author, title, and page 
count. (string author, string name, int pages)
Make the class a:
• Constructor public Book(string author, string name, int pages)
• Set and get book's author's name.
• Set and get the name of the book.
• Set and get the number of pages in the book.
In addition, make a public string Print() method for the book that will be used to 
print the book object. 
Create a list and add them to list.
For example, the method call should produce the following output:
Sample output
J. K. Rowling, Harry Potter and the Sorcerer's Stone, 223 pages

Task-2:
Create a "Person" class that describes a person. Each person has a FirstName, LastName 
and age. (string firstname, string lastname, int age)
Make the class a:
• Constructor Person(string firstname, string lastname, int age)
• Set name, last name and age 
• Create a list and add them to list.
• Show on screen
• In addition, make a public string Print() method for the person that will be 
used to print the person object.
*/

namespace ClassAndMethodExercise
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book("Strindberg", "Röda rummet", 250);
            Book book2 = new Book("J. K. Rowling", "Harry Potter and the Sorcerer's Stone", 223);

            //book1.Print();
            //book2.Print();

            books.Add(book1);
            books.Add(book2);

            foreach (Book book in books)
            {
                book.Print();
            }
            Console.WriteLine("___________________________________________________________");
            List<Person> persons = new List<Person>();
            Person person1 = new Person("August", "Strindberg", 2024 - 1849);
            Person person2 = new Person("J. K.", "Rowling", 2024 - 1965);

            persons.Add(person1);
            persons.Add(person2);
            foreach (Person person in persons)
            {
                person.Print();
                Console.WriteLine("___________________________________________________________");
            }

            do {
                Console.WriteLine("Firstname or type exit");
                Person p = new Person();
                p.FirstName = Console.ReadLine();
                if (p.FirstName == "exit") break;
                Console.WriteLine("Lastname ");
                p.LastName = Console.ReadLine();
                Console.WriteLine("Age ");
                p.Age = Convert.ToInt32(Console.ReadLine());
                persons.Add(p);
            } while (true);

            foreach (Person person in persons)
            {
                person.Print();
            }

            Console.ReadKey();
        }
    }
}

