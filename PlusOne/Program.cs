// See https://leetcode.com/problems/plus-one/ for more information
Console.WriteLine("Hello, World!");

var result = PlusOneOther(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 9 });

foreach (int i in result)
{
    Console.WriteLine(i);
}

Console.ReadLine();

int[] PlusOne(int[] digits)
{
    //Convert array to string
    //Convert string to number and add 1
    //Convert number into int array
    //This solution doesn't work if we try to parse a really large number into a long or other primitive data type.
    var numberAsString = string.Join("", digits);
    var finalNumber = long.Parse(numberAsString) + 1;
    var result = finalNumber.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
    return result;
}

int[] PlusOneOther(int[] digits)
{
    //Loop backward starting at last index
    //If last digit is less than 9, then we can just increment and return becuase there would be no carry
    //Otherwise, if last digit is 9, then when we add 1, we have to handle the carry due to it being = 10.
    //So we set that index = 0 and increment the preceeding index by 1.
    //If all digits in array are 9, that means the number will be increased by a decimal place
    //In this case, we have to create a new array with one extra indice.
    //The carry will always be 1 so we can set index 0 = 1 and return the array.
    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if (digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        digits[i] = 0;
    }
    var result = new int[digits.Length + 1];
    result[0] = 1;
    return result;
}