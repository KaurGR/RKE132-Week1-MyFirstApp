/* 
Console asks for name
user input(1)
Console responds Hello "input(1)"
*/

//Variables
string a;

Console.WriteLine("Hello, What's your name?");
a = Console.ReadLine();
//string a=Console.ReadLine();

//Console.WriteLine("Hello, " + a);
Console.WriteLine($"Hello {a}! ");
