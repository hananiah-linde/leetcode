// See https://leetcode.com/problems/sqrtx/ for more information
Console.WriteLine("Hello, World!");

var result = MySqrt(300);
Console.WriteLine(result);

Console.ReadLine();

int MySqrt(int x)
{
    //return (int)Math.Sqrt(x); Real world soltion
    if (x == 0) return 0;
    if (x == 1) return 1;
    long min = 0;
    long max = x;

    while (min < max)
    {
        long mid = min + (max - min) / 2;
        long candidate = mid * mid;

        if (candidate == x)
            return (int)mid;
        else if (candidate > x)
        {
            max = mid;
        }
        else
        {
            min = mid + 1;
        }
    }

    return (int)min - 1;
}