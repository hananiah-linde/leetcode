// https://leetcode.com/problems/implement-strstr/
Console.WriteLine("Hello, World!");

var result = StrStr("hello", "ll");

Console.WriteLine(result);
Console.ReadLine();

int StrStr(string haystack, string needle)
{
    int l1 = haystack.Length;
    int l2 = needle.Length;
    if (l2 > l1)
    {
        return -1;
    }

    if ((l1 == 0) || (l2 == 0))
    {
        return 0;
    }

    int i = 0;
    while (i <= (l1 - l2))
    {
        // In C# SubString takes StartIndex and Length as parameter unlike Java where it is Start and end Index
        string temp = haystack.Substring(i, l2);
        if (needle == temp)
        {
            return i;
        }
        i++;
    }

    return -1;
}