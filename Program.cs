using System;
using System.Collections.Generic;

namespace POSTMANAGEMENTSYSTEM
{
	public class Post
	{
		public string Content { get; set; }
		public DateTime Date { get; set; }
		public string Status { get; set; }
		public string ImageUrl { get; set; }
	}

	public class Program
	{
		public static List<Post> posts = new List<Post>();

		static void Main(string[] args)
		{
			bool running = true;

			while (running)
			{
				Console.WriteLine("1. Create a new post");
				Console.WriteLine("2. View all posts");
				Console.WriteLine("3. Exit");

				Console.Write("Enter your choice: ");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						CreatePost();
						break;
					case "2":
						ViewPosts();
						break;
					case "3":
						running = false;
						break;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}

				Console.WriteLine();
			}
		}

		static void CreatePost()
		{
			Console.Write("Enter the post content: ");
			string content = Console.ReadLine();

			Console.Write("Enter the post status: ");
			string status = Console.ReadLine();

			Console.Write("Enter the post date (yyyy-MM-dd): ");
			if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
			{
				Console.WriteLine("Invalid date format. Post creation canceled.");
				return;
			}

			Console.Write("Enter the image URL (leave blank for no image): ");
			string imageUrl = Console.ReadLine();

			Post newPost = new Post
			{
				Content = content,
				Date = date,
				Status = status,
				ImageUrl = imageUrl
			};

			posts.Add(newPost);

			Console.WriteLine("Post created successfully!");
		}

		static void ViewPosts()
		{
			if (posts.Count == 0)
			{
				Console.WriteLine("No posts found.");
				return;
			}

			Console.WriteLine("All Posts:");
			foreach (var post in posts)
			{
				Console.WriteLine($"Content: {post.Content}");
				Console.WriteLine($"Status: {post.Status}");
				Console.WriteLine($"Date: {post.Date.ToString("yyyy-MM-dd")}");
				Console.WriteLine($"Image URL: {post.ImageUrl}");
				Console.WriteLine();
			}
		}
	}
}