using System;
using System.Collections.Generic;

namespace MyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library mylibrary = new Library();
            Console.WriteLine("Welcome to Your Library!");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("A - add book");
                Console.WriteLine("S - search for a book");
                Console.WriteLine("L - look at books");
                Console.WriteLine("D - delete a book");
                Console.WriteLine("E - edit a book");
                Console.WriteLine("Q - quite");

                string action = Console.ReadLine();

                switch (action)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("You want to add a book");
                        addBook(mylibrary);
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("You want to search a book");
                        searchBook(mylibrary);
                        break;
                    case "L":
                    case "l":
                        Console.WriteLine("You want to look at all the books");
                        displayBooks(mylibrary);
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("You want to delete a book");
                        deleteBook(mylibrary);
                        break;
                    case "E":
                    case "e":
                        Console.WriteLine("You want to edit a book");
                        editBook(mylibrary);
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("You want to quit");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("That is not a registerd command");
                        break;
                }
            }
        }
        static public void addBook(Library mylibrary)
        {
            //add a book to library
            Book b;
            Console.Write("Title: ");
            string t = Console.ReadLine();
            Console.Write("Author: ");
            string a = Console.ReadLine();
            Console.Write("Description: ");
            string d = Console.ReadLine();
            if(String.IsNullOrEmpty(d))
            {
                b = new Book(t, a);
                Console.WriteLine($"Title: {b.Title}");
                Console.WriteLine($"Author: {b.Author}");
                mylibrary.AddBook(b);
            }
            else
            {
                Console.Write("Length: ");
                string l = Console.ReadLine();
                if (String.IsNullOrEmpty(l))
                {
                    b = new Book(t, a, d);
                    Console.WriteLine($"Title: {b.Title}");
                    Console.WriteLine($"Author: {b.Author}");
                    Console.WriteLine($"Description: {b.Description}");
                    mylibrary.AddBook(b);
                }
                else
                {
                    b = new Book(t, a, d, l);
                    Console.WriteLine($"Title: {b.Title}");
                    Console.WriteLine($"Author: {b.Author}");
                    Console.WriteLine($"Description: {b.Description}");
                    Console.WriteLine($"Length: {b.Length}");
                    mylibrary.AddBook(b);
                }
            }
            b.AddTags();
            
        }
        static public void searchBook(Library mylibrary)
        {
            List<Book> books = searchforBook(mylibrary);
            foreach(Book b in books)
            {
                Console.WriteLine(b.ToString());
            }
            //search for book in library
        }
        static public void displayBooks(Library mylibrary)
        {
            //display all books
            Console.WriteLine(mylibrary.ToString());
        }
        static public List<Book> searchforBook(Library mylibrary)
        {
            Console.WriteLine("What would you like to search by?");
            Console.WriteLine("A - Author");
            Console.WriteLine("Ti - Title");
            Console.WriteLine("Ta - Tags");
            Console.WriteLine("L - Length");
            Console.WriteLine("D - Description");
            string searchFactor = Console.ReadLine();
            List<Book> books = new List<Book>();
            switch(searchFactor)
            {
                case "A":
                case "a":
                    books = mylibrary.searchAuthor();
                    break;
                case "Ti":
                case "ti":
                    books = mylibrary.searchTitle();
                    break;
                case "Ta":
                case "ta":
                    books = mylibrary.searchTags();
                    break;
                case "L":
                case "l":
                    books = mylibrary.searchLength();
                    break;
                case "D":
                case "d":
                    books = mylibrary.searchDesc();
                    break;
                default:
                    Console.WriteLine("That was not an option");
                    books = searchforBook(mylibrary);
                    break;
            }
            return books;            
        }
        static public void editBook(Library mylibrary)
        {
            //edit existing book
            List<Book> books = searchforBook(mylibrary);
            int i = 0;
            foreach (Book b in books)
            {
                Console.WriteLine($"{i}: " + b.ToString());
            }
            Console.WriteLine("Select the number of the book you want to edit");
            string numString = Console.ReadLine();
            Int32.TryParse(numString, out int num);
            books[num].edit();
            Console.WriteLine(books[num].ToString());
        }
        static public void deleteBook(Library mylibrary)
        {
            List<Book> books = searchforBook(mylibrary);
            int i = 0;
            foreach (Book b in books)
            {
                Console.WriteLine($"{i}: " + b.ToString());
            }
            Console.WriteLine("Select the number of the book you want to delete");
            string numString = Console.ReadLine();
            Int32.TryParse(numString, out int num);
            mylibrary.delete(books[num]);
        }
    }
}
