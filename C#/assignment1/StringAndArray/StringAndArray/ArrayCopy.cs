namespace StringAndArray;

public class ArrayCopy
{
    public static void Run()
    {
        int[] initialArr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int[] copiedArray = new int[initialArr.Length];

        for (int i = 0; i < initialArr.Length; i++)
        {
            copiedArray[i] = initialArr[i];
        }
        
        Console.WriteLine("Initial Array: ");

        foreach (int number in initialArr)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Copied Array: ");

        foreach (int number in copiedArray)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
}