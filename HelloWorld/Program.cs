using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercise 1
            var namesList = new List<string>();
            var keepAsking = true;
            var likesMessage = "";
            while (keepAsking)
            {
                Console.Write("Enter a name: ");
                var value = Console.ReadLine();
                if (value == "")
                {
                    keepAsking = false;
                } 
                else
                {
                    namesList.Add(value);
                }
            }
            if (namesList.Count == 1)
            {
                likesMessage = namesList[0] + " likes your post.";
            } 
            else if (namesList.Count == 2)
            {
                likesMessage = namesList[0] + " and " + namesList[1] + " like your post.";
            } 
            else if (namesList.Count > 2)
            {
                likesMessage = namesList[0] + ", " + namesList[1] + " and " + (namesList.Count - 2) + " others like your post.";
            }
            Console.WriteLine(likesMessage);
        }
    }
}
