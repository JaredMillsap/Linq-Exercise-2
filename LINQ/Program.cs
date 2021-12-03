using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "NBA2K22", "NFL2K22", "NCAA 22", } ;

            IEnumerable<String> games = videoGames.Where(games.OrderByDescending()
            foreach (var Game in videoGames)
            {
                Console.WriteLine(Game);
            }

            var GameLength = videoGames.Contains(" ");
             `
            Console.WriteLine(GameLength);




            //var namelength = videoGames.Where(x => videoGames.Count == 4);

            //Console.WriteLine(namelength);

            //newList = list.OrderByDescending(x => x.Product.Name).ToList();
        }
        //OrderByDescending(x => x).ToList();
    }
}
