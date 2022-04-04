// https://leetcode.com/problems/search-insert-position/
Console.WriteLine("Hello, World!");

var result = SearchInsert(new int[] { 1, 2, 3, 5, 6 }, 5);
result = SearchInsert(new int[] { 1, 2, 3, 4, 5, }, 6);

Console.WriteLine(result);

Console.ReadLine();


int SearchInsert(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] >= target)
        {
            return i;
        }
    }

    return nums.Length;
}

int SearchInsertBinary (int[] nums, int target)
{
    int i = Array.BinarySearch(nums,target);
    return i >= 0 ? i : ~i;
}