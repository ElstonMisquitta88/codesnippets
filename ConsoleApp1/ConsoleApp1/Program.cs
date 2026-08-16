
using System.Text;

//---------------------------------------------------------------------------------
// (1) Reverse a string using StringBuilder
//---------------------------------------------------------------------------------

// Logic
// Start from:last character
// Move backwards.


//string input = "hello";
//StringBuilder reversed = new StringBuilder();
//for (int i = input.Length - 1; i >= 0; i--)
//{
//    reversed.Append(input[i]);
//}
//Console.WriteLine(reversed.ToString());

//---------------------------------------------------------------------------------
// (2) Check if string is palindrome
//---------------------------------------------------------------------------------

// Logic : Two Pointers
// Compare:
// first character
// last character
// Then move inward.

//string input1 = "madam";
//string input1 = "detartrated";
//bool isPalindrome = true;

//int left = 0;
//int right = input1.Length - 1;

//while (left < right)
//{
//    if (input1[left] != input1[right])
//    {
//        isPalindrome = false;
//        break;
//    }

//    left++;
//    right--;
//}

//Console.WriteLine(isPalindrome);

//---------------------------------------------------------------------------------
// [3] Anagram check
//---------------------------------------------------------------------------------
// “An anagram can be checked efficiently using a dictionary by counting character frequencies in one string 
// and decrementing counts using the second string.

//using System;
//using System.Collections.Generic;

//string str1 = "listen";
//string str2 = "silent";

//bool isAnagram = true;

//if (str1.Length != str2.Length)
//{
//    isAnagram = false;
//}
//else
//{
//    Dictionary<char, int> dict = new Dictionary<char, int>();

//    // (a) Count characters from first string
//    foreach (char c in str1)
//    {
//        if (dict.ContainsKey(c))
//            dict[c]++;
//        else
//            dict[c] = 1;
//    }
//    // At this point, dict contains the count of each character in str1 for "listen":
//    //Dictionary Will be : [('l', 1), ('i', 1), ('s', 1), ('t', 1), ('e', 1), ('n', 1)]

//    // (b) Reduce count using second string
//    foreach (char c in str2)
//    {
//        if (!dict.ContainsKey(c))
//        {
//            isAnagram = false;
//            break;
//        }

//        dict[c]--;

//        if (dict[c] < 0)
//        {
//            isAnagram = false;
//            break;
//        }
//    }
//}

//Console.WriteLine(isAnagram);


//---------------------------------------------------------------------------------
// [4] First Non-Repeating Character
//---------------------------------------------------------------------------------
/* 
using System;
using System.Collections.Generic;

string str1 = "sswwiss";

Dictionary<char, int> dict = new Dictionary<char, int>();

// (a) Count characters from first string
foreach (char c in str1)
{
    if (dict.ContainsKey(c))
        dict[c]++;
    else
        dict[c] = 1;
}

foreach (char c in str1)
{
    if (dict[c] == 1)
    {
        Console.WriteLine("First Non-Repeating Character: " + c);
        break;
    }
}
*/

//---------------------------------------------------------------------------------
// [5] Two Sum
//---------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

int[] nums = { 2, 8, 1, 15 };
int target = 9;

Dictionary<int, int> dict = new Dictionary<int, int>();

for (int i = 0; i < nums.Length; i++)
{
    int needed = target - nums[i];

    if (dict.ContainsKey(needed))
    {
        Console.WriteLine($"Indexes: {dict[needed]}, {i}");
        break;
    }

    dict[nums[i]] = i;
}



//---------------------------------------------------------------------------------
//---------------------------------------------------------------------------------
//---------------------------------------------------------------------------------


//using System;
//using System.Collections.Generic;

//string str1 = "aaabbbcee";

//Dictionary<char, int> dict = new Dictionary<char, int>();

//// (a) Count characters from first string
//foreach (char c in str1)
//{
//    if (dict.ContainsKey(c))
//        dict[c]++;
//    else
//        dict[c] = 1;
//}

//for(int i = 0; i < dict.Count; i++)
//{
//    Console.Write(dict.Values.ElementAt(i)+ dict.Keys.ElementAt(i).ToString());
//}

//Console.ReadLine();