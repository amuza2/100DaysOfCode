using System.Text.RegularExpressions;

string substring = "localhost/v1/getemp/666#123";

// Create a regular expression pattern that matches any character that is not alphanumeric
string pattern = @"^[a-zA-Z0-9]+$";

// Use the Regex.IsMatch() method to check if the substring matches the pattern
bool containsNonAlphanumeric = Regex.IsMatch(substring, pattern);

if (containsNonAlphanumeric)
{
    Console.WriteLine("The substring contains only alphanumeric characters.");
}
else
{
    Console.WriteLine("Invalid");
}
