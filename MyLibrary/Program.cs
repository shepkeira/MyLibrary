using System;

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
            Console.Write("Title: ");
            string t = Console.ReadLine();
            Console.Write("Author: ");
            string a = Console.ReadLine();
            Book b = new Book(t, a);
            Console.WriteLine($"Title: {b.Title}");
            Console.WriteLine($"Author: {b.Author}");
            mylibrary.AddBook(b);
        }
        static public void searchBook(Library mylibrary)
        {
            //search for book in library
        }
        static public void displayBooks(Library mylibrary)
        {
            Console.WriteLine(mylibrary);
            //display all books
        }
        static public void editBook(Library mylibrary)
        {
            //edit existing book
        }
        static public void deleteBook(Library mylibrary)
        {
            //delte a book
        }
    }
}
