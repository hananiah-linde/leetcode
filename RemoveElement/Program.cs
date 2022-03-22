// https://leetcode.com/problems/remove-element/
Console.WriteLine("Hello, World!");

var param = new int[] { 3, 2, 2, 3 };

var result = RemoveElement(param, 3);
Console.WriteLine(result);


Console.ReadLine();

int RemoveElement(int[] nums, int val)
{
    int j = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[j] = nums[i];
            j++;
        }
    }

    return j;
}
