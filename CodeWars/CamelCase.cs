using System;
using System.Linq;

public class CamelCase
{
  public static string ToCamelCase(string str)
  {
        var stringSplit = str.Split(new char[] { '-', '_' });

        var finishedWord = stringSplit[0];
        foreach(var word in stringSplit.Skip(1)){
            finishedWord += CapitalizeFirstChar(word);
        }

        return finishedWord;
  }

  static string CapitalizeFirstChar(string word){
        var firstChar = word[0].ToString().ToUpper();
        return firstChar + word.Substring(1);
    }
}