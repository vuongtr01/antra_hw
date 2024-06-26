namespace _02ConvertingTypes;

public class Greeting
{
    public static void Play()
    {
        DateTime currentTime = DateTime.Now;
        int hour = currentTime.Hour;
        if (hour >= 0 && hour < 6)
        {
            Console.WriteLine("Good Night");
        }
        else if (hour >= 6 && hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        else if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("Good Afternoon");
        }
        else if (hour >= 18 && hour < 24)
        {
            Console.WriteLine("Good Evening");
        }
    }
}