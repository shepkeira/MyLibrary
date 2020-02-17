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
		Tags = new List<string>();
	}
	public Book(string t, string a, string d)
	{
		Title = t;
		Author = a;
		Description = d;
		Tags = new List<string>();
	}
	public Book(string t, string a, string d, string l)
	{
		Title = t;
		Author = a;
		Description = d;
		Length = l;
		Tags = new List<string>();
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
				Tags.Add(tag);
			}
			
		}
		
	}

	public void edit()
	{
		bool done = false;
		Console.WriteLine(this);
		while (!done)
		{
			Console.WriteLine("What field would you like to edit?");
			Console.WriteLine("1 - Title\n2 - Author\n3 - Description\n4 - Length\n5 - Tags\n6 - None");
			string field = Console.ReadLine();
			switch (field)
			{
				case "1":
					Console.Write("New Title: ");
					string title = Console.ReadLine();
					Title = title;
					break;
				case "2":
					Console.Write("New Author: ");
					string author = Console.ReadLine();
					Author = author;
					break;
				case "3":
					Console.Write("New Description: ");
					string desc = Console.ReadLine();
					Description = desc;
					break;
				case "4":
					Console.Write("New Length: ");
					string len = Console.ReadLine();
					Length = len;
					break;
				case "5":
					editTags();
					break;
				case "6":
					done = true;
					break;
				default:
					Console.WriteLine("That is not one of the options");
					break;
			}
		}
	}

	public override string ToString()
	{
		string str = "";
		string title = $"Title: {Title}\n";
		string author = $"Author: {Author}\n";
		str += title + author;
		if (!String.IsNullOrEmpty(Description))
		{
			str += $"Description: {Description}\n";
		}
		if (!String.IsNullOrEmpty(Length))
		{
			str += $"Length: {Length}\n";
		}
		if (Tags.Count > 0)
		{
			str += $"Tags: ";
			foreach (string tag in Tags)
			{
				str += tag;
			}
		}
		return str;
	}

	private void editTags()
	{
		bool done = false;
		while(!done)
		{
			Console.WriteLine("1 - Edit\n2 - Delete\n3 - Done");
			string answer = Console.ReadLine();
			if (answer == "1")
			{
				//edittags
				int i = 0;
				foreach (string t in Tags)
				{
					Console.WriteLine($"{i}: " + t.ToString());
				}
				Console.WriteLine("Select the number of the tag you want to edit");
				string numString = Console.ReadLine();
				Int32.TryParse(numString, out int num);
				Console.WriteLine("What should that tag say?");
				string newTag = Console.ReadLine();
				Tags[num] = newTag;
			}
			else if (answer == "2")
			{
				//delete tags
				int i = 0;
				foreach (string t in Tags)
				{
					Console.WriteLine($"{i}: " + t.ToString());
				}
				Console.WriteLine("Select the number of the tag you want to delete");
				string numString = Console.ReadLine();
				Int32.TryParse(numString, out int num);
				Tags.RemoveAt(num - 1);
			}
			else if (answer == "3")
			{
				//done tags
				done = true;
			}
			else
			{
				Console.WriteLine("That is not one of the options");
			}
		}
	}
}
