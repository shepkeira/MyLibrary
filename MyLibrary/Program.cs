using System;

namespace MyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        addBook();
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("You want to search a book");
                        searchBook();
                        break;
                    case "L":
                    case "l":
                        Console.WriteLine("You want to look at all the books");
                        displayBooks();
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("You want to delete a book");
                        deleteBook();
                        break;
                    case "E":
                    case "e":
                        Console.WriteLine("You want to edit a book");
                        editBook();
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
        static public void addBook()
        {
            //add a book to library
        }
        static public void searchBook()
        {
            //search for book in library
        }
        static public void displayBooks()
        {
            //display all books
        }
        static public void editBook()
        {
            //edit existing book
        }
        static public void deleteBook()
        {
            //delte a book
        }
    }
}
