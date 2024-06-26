namespace StringAndArray;

public class ManageList
{
    public static void Run()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Enter command (+ item, - item, -- to clear or stop to stop)):");
        string command = Console.ReadLine();
        while (command != "stop")
        {
            if (command == "--")
            {
                items = new List<string>();
            }
            else
            {
                char action = command[0];
                string item = command[2..];
                // Console.WriteLine($"action: {action}");
                // Console.WriteLine($"item: {item}");
                if (action == '+')
                {
                    items.Add(item);
                }
                else
                {
                    items.Remove(item);
                }
            }
            
            Console.WriteLine("Current List: ");
            foreach (string it in items)
            {
                Console.Write($"{it} ");
                
            }
            Console.WriteLine();
            Console.WriteLine("Enter command (+ item, - item, -- to clear or stop to stop)):");
            command = Console.ReadLine();
        }
    }
}