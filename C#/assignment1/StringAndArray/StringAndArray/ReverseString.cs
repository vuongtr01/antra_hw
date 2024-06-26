namespace StringAndArray;

public class ReverseString
{
    public static void RunMethod1()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        char[] charList = new char[input.Length];

        for (int i = 0; i < input.Length; i ++)
        {
            charList[i] = input[i];
        }

        Array.Reverse(charList);
        Console.WriteLine(new String(charList));
    }

    public static void RunMethod2()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        for (int i = input.Length-1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }
}