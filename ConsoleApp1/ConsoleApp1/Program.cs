
// (1) Reverse a string using StringBuilder
// Logic
// Start from:last character
// Move backwards.

using System.Text;
string input = "hello";
StringBuilder reversed = new StringBuilder();
for (int i = input.Length - 1; i >= 0; i--)
{
    reversed.Append(input[i]);
}
Console.WriteLine(reversed.ToString());