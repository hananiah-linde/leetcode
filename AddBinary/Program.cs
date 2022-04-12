// See https://leetcode.com/problems/add-binary/ for more information
using System.Text;

Console.WriteLine("Hello, World!");

var result = AddBinary("111110101110111101011111", "1011"); //10 + 11 return 010101

Console.WriteLine(result);

Console.ReadLine();

string AddBinary(string a, string b)
{
    if (a.Length < 23 && b.Length < 23) return Convert.ToString((Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2)), 2);

    var carry = 0;
    var builder = new StringBuilder();

    var aLength = a.Length - 1;
    var bLength = b.Length - 1;

    int aVal, bVal, val;
    while (aLength >= 0 || bLength >= 0)
    {
        aVal = aLength >= 0 ? a[aLength] - '0' : 0;
        bVal = bLength >= 0 ? b[bLength] - '0' : 0;

        val = aVal + bVal + carry;
        builder.Insert(0, val & 1);

        carry = val >> 1;

        aLength--;
        bLength--;
    }

    if (carry >= 1)
    {
        builder.Insert(0, carry);
    }

    return builder.ToString();

}
