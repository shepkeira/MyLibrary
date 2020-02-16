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
			string title = $"Title: {b.Title}\n";
			string author = $"Author: {b.Author}\n";
			str += title + author + "\n";
		}
		return str;
	}
}
