using System;
using System.Collections.Generic;

public class POSTMANAGEMENTSYSTEM
{
    static List<string> posts = new List<string>();
    
    static string studnum = "00065";
    static string userInput, postmenu, postinput, postprivacy, postconfirm,found;

    public static void Main(String[]args)
    {
        System.Console.WriteLine("Welcome to PUPHUB Posts & Bulletin Board!");
        System.Console.WriteLine("-----------------------------------------");
        System.Console.WriteLine();

        System.Console.Write("Please enter your student number: ");
        userInput = Console.ReadLine();

        while(userInput != "3")
        {

        if(userInput == studnum)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Press 1 to create a post.");
            System.Console.WriteLine("Press 2 to view all posts.");
            System.Console.WriteLine("Press 3 to exit program.");
            postmenu = Console.ReadLine();

            if(postmenu == "1")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("What's on your mind?");
                postinput = Console.ReadLine();

                System.Console.WriteLine();
                System.Console.WriteLine("Do you want your post to be public or private?");
                postprivacy = Console.ReadLine();

                System.Console.WriteLine();
                System.Console.WriteLine("Post Confirmation");
                System.Console.WriteLine("Press y to post");
                System.Console.WriteLine("Press n to cancel");
                System.Console.WriteLine();
                postconfirm =  Console.ReadLine();

                if(postconfirm == "y")
                {
                    posts.Add(postinput);
                    System.Console.WriteLine("Status Updated!");
                    System.Console.WriteLine();
                }
                else
                {
                    System.Console.WriteLine("Post cancelled.");
                }
            }
            else if(postmenu == "2")
            {
                foreach(var post in posts)
                {
                    System.Console.WriteLine();
                    System.Console.Write("Posted: ");
                    System.Console.WriteLine(post);
                }
            }
            else if(postmenu == "3")
            {
                System.Console.WriteLine("Exiting Program.");
                break;
            }
        }
        else
        {
            System.Console.WriteLine();
            System.Console.WriteLine("This account does not exist. Exiting program");
            break;
        }

        }
    }
}
