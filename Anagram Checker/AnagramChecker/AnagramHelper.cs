// See https://aka.ms/new-console-template for more information
public class AnagramHelper
{
    public bool isAnagram(string word1, string word2)
    {
        var word1Characters = word1.ToCharArray().ToList();
        var word2Characters = word2.ToCharArray().ToList();
        var difference = word1Characters.Except(word2Characters).ToList();
        return difference.Count() == 0 && word1.Length == word2.Length ? true : false;
    }
}