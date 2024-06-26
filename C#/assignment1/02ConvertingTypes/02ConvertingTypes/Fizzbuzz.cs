using System.Text;

namespace _02ConvertingTypes;

public class Fizzbuzz
{
    public static void Play()
    {
        StringBuilder result = new StringBuilder("");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 15 == 0)
            {
                result.Append("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                result.Append("fizz");
            } else if (i % 5 == 0)
            {
                result.Append("buzz");
            }
            else
            {
                result.Append(i);
            }
        }
        
        Console.WriteLine(result.ToString());
    }
}