// https://leetcode.com/problems/maximum-subarray/
Console.WriteLine("Hello, World!");

var result = MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

Console.WriteLine(result);

Console.ReadLine();

int MaxSubArray(int[] nums)
{
    int sum = 0;
    int maxSum = nums[0]; //if only 1 number, then its automatically the max sum

    for(int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];

        if (nums[i] > sum)
        {
            sum = nums[i];
        }

        if (sum > maxSum)
        {
            maxSum = sum;
        }
    }
    return maxSum;
}
