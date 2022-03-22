// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
Console.WriteLine("Hello, World!");

var param = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

var result = RemoveDuplicatesTwo(param);

Console.WriteLine(result);

Console.ReadLine();

int RemoveDuplicates(int[] nums)
{
    int i = 0; //index for our "new" in-place array
    foreach (int num in nums)
    {
        if (nums[i] != num) //Since array is sorted, we can simply take the next value thats not equal and place it at the next indice
        {
            nums[++i] = num;
        }

    }
    return nums.Length != 0 ? i + 1 : 0; //i would be the last indice of our inplace array. Return i+1 to get the number of elements

}

int RemoveDuplicatesTwo(int[] nums)
{
    var resultIndex = 0; //index for our "new" in-place array
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i - 1] == nums[i]) continue; //Its a duplicate, so we don't want to update our result index

        resultIndex++;
        nums[resultIndex] = nums[i];
    }

    return nums.Length != 0 ? resultIndex + 1 : 0;
}