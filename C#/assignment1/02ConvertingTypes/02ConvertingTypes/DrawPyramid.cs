namespace _02ConvertingTypes;

public class DrawPyramid
{
    public static void Play()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < 5 - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}