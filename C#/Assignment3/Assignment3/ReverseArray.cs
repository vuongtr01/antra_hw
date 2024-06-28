namespace Assignment3;

public class ReverseArray
{
    private static int[] GenerateNumbers()
    {
        List<int> numberList = new List<int>();
        bool addMore = true;
        while (addMore)
        {
            Console.WriteLine("Number to add: ");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            numberList.Add(newNumber);
            Console.WriteLine("Want to add more(Y/N): ");
            string ans = Console.ReadLine();
            if (ans == "N")
            {
                addMore = false;
            }
        }

        return numberList.ToArray();
    }

    private static void Reverse(int[] myArray)
    {
        // [1,2,3, 4, 5] ----> [5, 4, 3, 2, 1]
        int left = 0;
        int right = myArray.Length - 1;

        while (left < right)
        {
            int temp = myArray[left];
            myArray[left] = myArray[right];
            myArray[right] = temp;

            left += 1;
            right -= 1;
        }
    }

    private static void PrintNumbers(int[] myArr)
    {
        foreach (var num in myArr)
        {
            Console.Write($"{num} ");
        }
        
        Console.WriteLine();
    }

    public static void Run()
    {
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);
    }
}