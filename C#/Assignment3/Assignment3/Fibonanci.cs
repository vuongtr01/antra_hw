namespace Assignment3;

public class Fibonanci
{
    private static int GetFibo(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }

        return GetFibo(n - 1) + GetFibo(n - 2);
    }

    public static void PrintFibo()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(GetFibo(i));
        }
    }
}