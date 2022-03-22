// https://leetcode.com/problems/valid-parentheses/
Console.WriteLine("Hello, World!");

var result = isValid("()[]{}");

Console.WriteLine(result);

Console.ReadLine();

bool isValid(string s)
{
    Stack<char> sign = new Stack<char>();

    foreach (var item in s.ToCharArray())
    {
        if (item == '(')
            sign.Push(')');
        else if (item == '[')
            sign.Push(']');
        else if (item == '{')
            sign.Push('}');
        else if (sign.Count == 0 || sign.Pop() != item)
            return false;
    }

    return sign.Count == 0;
}