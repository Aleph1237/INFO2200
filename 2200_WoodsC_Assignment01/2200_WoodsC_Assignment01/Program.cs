//Name: Corbin Woods
//Class: INFO 2200
//Section: 001
//Professor: Prof. Sharp
//Date: 1/20/25
//Participation or Assignment #: 01
//By submitting this assignment, I declare that the source code contained in this assignment was written #solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, #in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment #instructions, nor obtained from a subscription service. I understand that copying any source code, #in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that #I will receive a zero on this project if I am found in violation of this policy.


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2200_WoodsC_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Corbin's College City Lookup App!"); 
            Console.WriteLine(); // Blank line

            // Prompt the user for input
            Console.Write("Please enter a college, and I will return the city it is located in (x to exit): ");
            string userInput = Console.ReadLine().ToLower();

            // Create a dictionary to store college-city pairs
            Dictionary<string, string> collegeDict = new Dictionary<string, string>();

            // Read the contents of the file
            using (StreamReader reader = new StreamReader("collegecities.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine(); // Read each line
                    string[] tempCollegeCity = line.Split(','); // Split into college and city
                    string college = tempCollegeCity[0];
                    string city = tempCollegeCity[1];
                    collegeDict.Add(college.ToUpper(), city); // Add to dictionary with college as key (uppercase for case-insensitive comparison)
                }
            }

            // Random selection code begin
            Random rand = new Random();

            // Main loop
            while (userInput != "x")
            {
                if (userInput == "random")
                {
                    // Select a random college
                    int randomIndex = rand.Next(collegeDict.Count);
                    string randomCollege = collegeDict.ElementAt(randomIndex).Key;

                    // get and display the city for the random college
                    if (collegeDict.TryGetValue(randomCollege, out string randomCity))
                    {
                        Console.WriteLine(); 
                        Console.WriteLine($"Random College: {randomCollege}");
                        Console.WriteLine($"City: {randomCity}");
                        Console.WriteLine(); 
                    }
                }
                else if (collegeDict.TryGetValue(userInput.ToUpper(), out string city))
                {
                    // Display the city for the entered college
                    Console.WriteLine(); 
                    Console.WriteLine($"College: {userInput}");
                    Console.WriteLine($"City: {city}");
                    Console.WriteLine(); 
                }
                else
                {
                    // Display error message for input that isnt in the dictionary
                    Console.WriteLine($"Could not find {userInput} in the database.");
                    Console.WriteLine(); 
                }

                // Prompt for following user input
                Console.Write("Please enter a college, and I will return the city it is located in (x to exit): ");
                userInput = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Goodbye!");
            Console.ReadLine(); // keeps the window open after user pressed X
        }
    }
}
