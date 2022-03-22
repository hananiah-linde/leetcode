//TWO SUM - leet code
/*

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

 */
Console.WriteLine("Hello, World!");

//var result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);

var result2 = TwoSum(new int[] { 3, 2, 4 }, 6);


Console.WriteLine($"Indices: {result2[0]} {result2[1]}");

Console.ReadLine();

static int[] TwoSum(int[] nums, int target)
{
    //Brute force: 
    //for (int i = 0; i < nums.Length; i++)
    //{
    //    for (var j = i + 1; j < nums.Length; j++)
    //    {
    //        if (nums[i] + nums[j] == target)
    //        {
    //            return new int[] { i, j };
    //        }
    //    }
    //}
    Dictionary<int, int> storage = new();

    for (int i = 0; i < nums.Length; i++)
    {
        var valueNeeded = target - nums[i];
        var currentIndex = i;
        var valueAtCurrentIndex = nums[currentIndex];

        //check storage before adding since we can't use the same element twice.
        if (storage.ContainsKey(valueNeeded)) //values added together will add to target
        {
            //Return the indices:
            var indexOfValueNeeded = storage[valueNeeded];
            return new int[] { currentIndex, indexOfValueNeeded };
        }

        if(!storage.ContainsKey(valueAtCurrentIndex)) //Don't add if it already exists.
        {
            storage.Add(valueAtCurrentIndex, currentIndex);
        }

        //if (storage.ContainsKey(target - nums[i]))
        //{
        //    return new int[] { i, storage[target - nums[i]] };
        //}
        //else if (!storage.ContainsKey(nums[i]))
        //{
        //    storage.Add(nums[i], i);
        //}
    }
    return Array.Empty<int>();
}

