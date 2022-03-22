//https://leetcode.com/problems/roman-to-integer/

Console.WriteLine("LeetCode: Roman To Integer!");

var result = RomanToInt("MCMXCIV");
Console.WriteLine(result);

Console.ReadLine();

int RomanToInt(string s)
{
    var counter = 0;

    var dictionary = new Dictionary<char, int> {
    { 'I', 1 },
    { 'V', 5 },
    { 'X', 10 },
    { 'L', 50 },
    { 'C', 100 },
    { 'D', 500 },
    { 'M', 1000 }
    };

    for (var i = 0; i < s.Length; i++)
    {
        if (i == 0)
        {
            counter += dictionary[s[i]];
            continue;
        }
        if (dictionary[s[i - 1]] >= dictionary[s[i]])
        {
            // keep going
            counter += dictionary[s[i]];
        }
        else
        {
            counter = counter + dictionary[s[i]] - (2 * dictionary[s[i - 1]]);
        }
    }

    return counter;
}

/*
Algorithm:
Create Dictionary to map Numerals to Numbers
Loop over each character in string s and add to a counter
The first index will automatically add to counter since we know we aren't doing a 'subraction'
Then we check if the previous value in the dictionary is greater or equal to the current value in the dictionary
If it is, the we don't have to worry about a subtraction since a subtraction only happens when a smaller numeral is before a larger numeral.
If the previous value is less than the the current value, then we need to add the current value minus 2x the previous value.
2x becuase we added the previous value on the previous loop so we need to remove that since that numeral is only used to subtract from the next numeral.
*/