namespace _02ConvertingTypes;

public class Birthdate
{
    public static void Play()
    {
        DateTime birthDate = new DateTime(2001, 2, 13);
        
        TimeSpan age = DateTime.Today - birthDate;
        int daysOld = (int)age.TotalDays;
        
        Console.WriteLine($"You are {daysOld} days old.");
        
        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversary = DateTime.Today.AddDays(daysToNextAnniversary);
        
        Console.WriteLine($"Your next 10,000-day anniversary will be on: {nextAnniversary:d}");
    }
}