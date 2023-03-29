//Take one string from the input and print its last 5 characters.

Console.WriteLine("Enter a string");
string input = Console.ReadLine();

string output = input.Substring(input.Length - 5);
Console.WriteLine(output);
Console.ReadLine();




