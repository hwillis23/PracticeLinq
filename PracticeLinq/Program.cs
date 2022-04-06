using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>
            {"Donkey Kong Country", "Mario World","Legends of Zelda","Super Mario Cart", "NBA","Duck Hunt","Mortal Kombat"};

            var games2 = games.OrderBy(name => name.Length).OrderBy(name => name.Length).ToList();  
            foreach (var game in games2)
            {
                Console.WriteLine(game);
            }    



        }
    }
}


//Create a list of video game names...///// don't forget to use foreach because it's a list to call it with CWL
//Order the list of games by length of the game name.- use OrderBy() 
//Use the lambda expression => in this exercise as well.
//use Method Syntax for this exercise //
