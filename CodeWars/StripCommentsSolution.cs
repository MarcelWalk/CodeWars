using System.Linq;
using System.Text.RegularExpressions;
public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        

        var pattern = ".*(" + commentSymbols.Aggregate((a,b) => a + ".*|" + b) + ".*)";//Filters comments in groups

        var matches = Regex.Matches(text, pattern);

        foreach (Match item in matches)
        {
            if(text != "" || item.Groups[1].Value != "")
            text = text.Replace(item.Groups[1].Value, "").Trim();
        }

        return text;
    }
}