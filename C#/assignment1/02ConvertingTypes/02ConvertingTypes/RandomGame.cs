namespace _02ConvertingTypes;

public class RandomGame
{
    public static void Play()
    {
        int correctNumber = new Random().Next(3) + 1;
        
        Console.Write("Guess the number: ");
        int guess = int.Parse(Console.ReadLine());

        if (guess < 1 || guess > 3)
        {
            Console.WriteLine("Please guess number between 1 and 3 only");
        }
        else if (guess == correctNumber)
        {
            Console.WriteLine("Correct");   
        }
        else if (guess > correctNumber)
        {
            Console.WriteLine("The correct number is smaller");
        }
        else
        {
            Console.WriteLine("The correct number is larger");
        }
    }
}