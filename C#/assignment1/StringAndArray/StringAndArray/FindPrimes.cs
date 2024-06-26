namespace StringAndArray;

public class FindPrimes
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;
        int limit = (int)Math.Sqrt(number);
        for (int divisor = 3; divisor <= limit; divisor += 2)
        {
            if (number % divisor == 0)
                return false;
        }

        return true;
    }

    public static int[] Run(int numbers)
    {
        List<int> result = new List<int>();

        for (int i= 1; i <= numbers; i++)
        {
            if (IsPrime(i))
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
}