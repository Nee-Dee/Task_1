static string reverse(string str)
{
    char[] input_array = str.ToCharArray();
    Array.Reverse(input_array);
    return new string(input_array);
}


string input_string;
string substring1;
input_string = Console.ReadLine();
if (input_string.Length % 2 == 0)
{
    string substring2;
    substring1 = reverse(input_string.Substring(0, input_string.Length / 2));
    substring2 = reverse(input_string.Substring(input_string.Length / 2));
    Console.WriteLine(substring1 + substring2);
}
else
{
    substring1 = reverse(input_string);
    Console.WriteLine(substring1 + input_string);
}
