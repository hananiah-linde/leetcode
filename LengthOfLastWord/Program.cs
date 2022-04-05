// See https://leetcode.com/problems/length-of-last-word/ for more information
Console.WriteLine("Hello, World!");

var result = LengthOfLastWord("   fly me   to   the moon  ");
Console.WriteLine(result);

Console.ReadLine();

int LengthOfLastWord(string s)
{
    //Trim trailing and leading whitespace.
    //Use split to add each word/whitespace into array
    //Use LastOrDefault().length to get length of last word
    return s.Trim().Split().LastOrDefault().Length;
}