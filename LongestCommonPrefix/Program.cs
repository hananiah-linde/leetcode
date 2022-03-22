// https://leetcode.com/problems/longest-common-prefix/
Console.WriteLine("LeetCode: Longest Common Prefix!");

var test = LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

Console.WriteLine(test);

Console.ReadLine();

string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0 || Array.IndexOf(strs, "") != -1)
        return "";

    string result = strs[0];
    int i = result.Length;
    foreach (string word in strs)
    {
        int j = 0;
        foreach (char c in word)
        {
            if (j >= i || result[j] != c)
                break;
            j += 1;
        }
        i = Math.Min(i, j);
    }
    return result.Substring(0, i);
}