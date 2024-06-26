namespace _02ConvertingTypes;

public class Counting
{
    public static void Play()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j <= 24; j += i)
            {
                if (j < 24)
                {
                    Console.Write($"{j}, ");
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}