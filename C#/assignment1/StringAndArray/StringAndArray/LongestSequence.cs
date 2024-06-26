namespace StringAndArray;

public class LongestSequence
{
    public static void Run()
    {
        Console.WriteLine("array elements: ");
        string numbersString = Console.ReadLine();

        List<int> inputList = new List<int>();

        string[] numberStringArr = numbersString.Split(" ");
        int[] numberArr = new int[numberStringArr.Length];

        for (int i = 0; i < numberStringArr.Length; i++)
        {
            numberArr[i] = int.Parse(numberStringArr[i]);
        }

        int leftPointer = 0;
        int rightPointer = 0;
        int maxRepeatLength = 0;
        int maxRepeatStart = 0;
        
        while (rightPointer < numberArr.Length)
        {

            if (numberArr[rightPointer] == numberArr[leftPointer])
            {
                rightPointer += 1;
            }
            else
            {
                if (maxRepeatLength < rightPointer - leftPointer)
                {
                    maxRepeatLength = rightPointer - leftPointer;
                    maxRepeatStart = leftPointer;
                }
                leftPointer = rightPointer;
                rightPointer += 1;
            }
        }
        if (maxRepeatLength < rightPointer - leftPointer)
        {
            maxRepeatLength = rightPointer - leftPointer;
            maxRepeatStart = leftPointer;
        }

        for (int i = maxRepeatStart; i < maxRepeatStart + maxRepeatLength; i++)
        {
            Console.WriteLine(numberArr[i]);
        }
    }
}