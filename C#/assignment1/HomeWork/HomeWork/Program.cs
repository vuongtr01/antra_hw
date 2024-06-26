// See https://aka.ms/new-console-template for more information
//Console.Write("What is your name: ");
// String name = Console.ReadLine();
// Console.WriteLine($"Hello {name}");
//
// Console.Write("What is your age: ");
// int age =int.Parse(Console.ReadLine());
// Console.WriteLine($"after 2 years, you will be {age + 2}");

Console.Write("What is your age: ");                                
string ageInput = Console.ReadLine();

if (int.TryParse(ageInput, out int ageInt))
{
    Console.WriteLine($"After two years, you will be: {ageInt + 2}");
}
else
{
    Console.WriteLine("Please enter correct age format!!");
}