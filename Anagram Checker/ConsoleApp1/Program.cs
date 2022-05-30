// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the First Word!");
var firstWord = Console.ReadLine();

Console.WriteLine("Enter the Second Word!");
var secondWord = Console.ReadLine();

var anagram = new AnagramHelper();
var isAnagram = anagram.isAnagram(firstWord, secondWord);
if (isAnagram)
{
    Console.WriteLine($"{secondWord} is an anagram of {firstWord}");
}
else
{
    Console.WriteLine($"{secondWord} is not an anagram of {firstWord}");
}

Console.Read();
