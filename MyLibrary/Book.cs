using System;
using System.Collections.Generic;

public class Book
{
	public string title;
	public string Title
	{
		get;
		set;
	}
	public string author;
	public string Author
	{
		get;
		set;
	}
	public string description;
	public string Description
	{
		get;
		set;
	}
	public string length;
	public string Length
	{
		get;
		set;
	}
	List<string> tags = new List<string>();
	public List<string> Tags
	{
		get;
		set;
	}

	public Book(string t, string a)
	{
		Title = t;
		Author = a;
	}
	public Book(string t, string a, string d)
	{
		Title = t;
		Author = a;
		Description = d;
	}
	public Book(string t, string a, string d, string l)
	{
		Title = t;
		Author = a;
		Description = d;
		Length = l;
	}

	public void AddTags()
	{
		bool quit = false;
		Console.WriteLine("What tag would you like to add? (enter q to finish entering tags)");
		while(!quit)
		{
			string tag = Console.ReadLine();
			if(tag == "q")
			{
				quit = true;
			}
			else
			{
				tags.Add(tag);
			}
			
		}
		
	}
}
