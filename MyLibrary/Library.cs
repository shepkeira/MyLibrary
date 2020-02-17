using System;
using System.Collections.Generic;

public class Library
{
	public List<Book> books = new List<Book>();
	public Library()
	{
	}
	public void AddBook(Book b)
    {
		books.Add(b);
    }

	public override string ToString()
	{
		string str = "";
		foreach(Book b in books)
		{
			str += b.ToString();
			str += "\n";
		}
		return str;
	}

	public List<Book> searchAuthor()
	{
		Console.WriteLine("What is the name of the Author?");
		string name = Console.ReadLine();
		List<Book> returnlist = new List<Book>();
		foreach(Book b in books)
		{
			if(b.Author.Contains(name))
			{
				returnlist.Add(b);
			}
		}
		return returnlist;
	}

	public List<Book> searchTitle()
	{
		Console.WriteLine("What is the name of the Author?");
		string name = Console.ReadLine();
		List<Book> returnlist = new List<Book>();
		foreach (Book b in books)
		{
			if (b.Title.Contains(name))
			{
				returnlist.Add(b);
			}
		}
		return returnlist;
	}

	internal void delete(Book book)
	{
		books.Remove(book);
	}

	public List<Book> searchTags()
	{
		Console.WriteLine("What is the tag?");
		string tag = Console.ReadLine();
		List<Book> returnlist = new List<Book>();
		foreach (Book b in books)
		{
			foreach (string t in b.Tags)
			{
				if(t == tag)
				{
					returnlist.Add(b);
					break;
				}
			}
		}
		return returnlist;
	}

	public List<Book> searchLength()
	{
		Console.WriteLine("What is the length?");
		string len = Console.ReadLine();
		List<Book> returnlist = new List<Book>();
		foreach (Book b in books)
		{
			if (b.Length.Contains(len))
			{
				returnlist.Add(b);
			}
		}
		return returnlist;
	}

	public List<Book> searchDesc()
	{
		Console.WriteLine("What is the description?");
		string desc = Console.ReadLine();
		List<Book> returnlist = new List<Book>();
		foreach (Book b in books)
		{
			if (b.Description.Contains(desc))
			{
				returnlist.Add(b);
			}
		}
		return returnlist;
	}
}
