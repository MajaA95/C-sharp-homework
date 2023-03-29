//Take a sentence as input and print its words.

Console.WriteLine("Enter a sentence");
string sentence = Console.ReadLine();

string[] splited = sentence.Split(' ');

foreach (string s in splited)
{ Console.WriteLine(s); }

Console.ReadLine();