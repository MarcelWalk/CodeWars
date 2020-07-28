using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeWars
{
    public class StockList
    {

        /*
        EXPLANATION

        A bookseller has lots of books classified in 26 categories labeled A, B, ... Z. 
        Each book has a code c of 3, 4, 5 or more characters. 
        The 1st character of a code is a capital letter which defines the book category.

        In the bookseller's stocklist each code c is followed by a space and by a positive integer n (int n >= 0) 
        which indicates the quantity of books of this code in stock.
        */

        public static string Solution(String[] lstOfArt, String[] lstOf1stLetter)
        {
            //Dictionary for articles
            Dictionary<string, int> articles = new Dictionary<string, int>();

            //Initialize directory with expected categories
            foreach (var item in lstOf1stLetter)
            {
                articles.Add(item, 0);
            }

            //Add amount for every category
            foreach (var art in lstOfArt)
            {
                //Split the item to get the category and amount
                var artSplit = art.Split(' ');
                var artCat = artSplit[0].First().ToString();

                //If category in input list add the amount
                if (articles.Keys.Contains(artCat))
                {
                    articles[artCat] += int.Parse(artSplit[1]);
                }
            }

            //If all are empty return a empty string
            if (articles.All(x => x.Value == 0))
                return "";
            else
                return articles.Where(x => lstOf1stLetter.Contains(x.Key)).Select(x => $"({x.Key} : {x.Value})").Aggregate((a, b) => a + " - " + b);
        }
    }
}
