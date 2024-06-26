namespace StringAndArray;

public class RotateArray
{
    public static int[] Run()
    {
        Console.WriteLine("array elements: ");
        string numbersString = Console.ReadLine();
        int numberOfRotated = int.Parse(Console.ReadLine());

        List<int> inputList = new List<int>();

        string[] numberStringArr = numbersString.Split(" ");
        int[] numberArr = new int[numberStringArr.Length];

        for (int i = 0; i < numberStringArr.Length; i++)
        {
            numberArr[i] = int.Parse(numberStringArr[i]);
        }

        int[] res = new int[numberStringArr.Length];
        // foreach (int num in numberArr)
        // {
        //     Console.WriteLine(num);
        // }
            
        Console.WriteLine("=======");
        int size = numberArr.Length;
        for (int i = 1; i <= numberOfRotated; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int newPosition = (i + j) % size;
                res[newPosition] += numberArr[j];
            }
        }

        return res;
    }
}