using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class TopWords
    {

        /*
        Write a function that, given a string of text (possibly with punctuation and line-breaks), returns an array of the top-3 most occurring words, in descending order of the number of occurrences.

        Assumptions:
        A word is a string of letters (A to Z) optionally containing one or more apostrophes (') in ASCII. (No need to handle fancy punctuation.)
        Matches should be case-insensitive, and the words in the result should be lowercased.
        Ties may be broken arbitrarily.
        If a text contains fewer than three unique words, then either the top-2 or top-1 words should be returned, or an empty array if a text contains no words.
        */

        public static List<string> Top3(string s)
        {
            //Dictionary for keeping track of the word count
            var wordDictionary = new Dictionary<string, int>();

            Regex reg = new Regex(@"\w+'?\w*");

            foreach (Match match in reg.Matches(s.ToLower()))
            {
                if (match.Value != "")
                {
                    if (wordDictionary.ContainsKey(match.Value))
                        wordDictionary[match.Value]++;
                    else
                        wordDictionary.Add(match.Value, 1);
                }
            }

            return wordDictionary.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key).ToList();
        }
    }
}
