// See https://leetcode.com/problems/climbing-stairs/ for more information
Console.WriteLine("Hello, World!");

var result = ClimbStairs(15);
Console.WriteLine(result);
Console.ReadLine();

int ClimbStairs(int n)
{
    if (n < 3)
        return n;

    int[] dp = new int[n + 1]; //array represents number of ways to climb n steps where the index is equal to n
    dp[0] = 1; //only 1 way to climb 0 steps
    dp[1] = 1; //only 1 way to climb 1 steps

    for (int i = 2; i <= n; i++)
    {
        dp[i] = dp[i - 1] + dp[i - 2]; //either you are coming from previous step (i-1) or two steps below (i-2)
    }

    return dp[n];
}