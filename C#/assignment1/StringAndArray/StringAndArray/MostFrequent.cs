namespace StringAndArray;

public class MostFrequent
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
        
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        
        foreach (int number in numberArr)
        {
            if (frequencyMap.ContainsKey(number))
            {
                frequencyMap[number]++;
            }
            else
            {
                frequencyMap[number] = 1;
            }
        }
        
        int mostFrequentNumber = numberArr[0]; 
        int maxFrequency = frequencyMap[numberArr[0]]; 

        foreach (var kvp in frequencyMap)
        {
            if (kvp.Value > maxFrequency)
            {
                mostFrequentNumber = kvp.Key;
                maxFrequency = kvp.Value;
            }
        }

        Console.WriteLine("Most frequent number: " + mostFrequentNumber);
    }
}