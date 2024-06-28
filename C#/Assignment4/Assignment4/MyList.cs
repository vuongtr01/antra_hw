namespace Assignment4;

public class MyList<T>
{
    private ListNode<T> head;
    private int count;

    public MyList()
    {
        head = null;
        count = 0;
    }

    // 1. Add an element to the list
    public void Add(T element)
    {
        if (head == null)
        {
            head = new ListNode<T>(element);
        }
        else
        {
            ListNode<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new ListNode<T>(element);
        }
        count++;
    }

    // 2. Remove an element at a specified index and return it
    public T Remove(int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException(nameof(index));

        ListNode<T> current = head;
        ListNode<T> previous = null;

        for (int i = 0; i < index; i++)
        {
            previous = current;
            current = current.Next;
        }

        if (previous == null)
        {
            head = current.Next;
        }
        else
        {
            previous.Next = current.Next;
        }

        count--;
        return current.Value;
    }

    // 3. Check if the list contains an element
    public bool Contains(T element)
    {
        ListNode<T> current = head;
        while (current != null)
        {
            if (current.Value.Equals(element))
                return true;
            current = current.Next;
        }
        return false;
    }

    // 4. Clear the list
    public void Clear()
    {
        head = null;
        count = 0;
    }

    // 5. Insert an element at a specified index
    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > count)
            throw new ArgumentOutOfRangeException(nameof(index));

        ListNode<T> newNode = new ListNode<T>(element);

        if (index == 0)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            ListNode<T> current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        count++;
    }

    // 6. Delete an element at a specified index
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException(nameof(index));

        ListNode<T> current = head;
        ListNode<T> previous = null;

        for (int i = 0; i < index; i++)
        {
            previous = current;
            current = current.Next;
        }

        if (previous == null)
        {
            head = current.Next;
        }
        else
        {
            previous.Next = current.Next;
        }

        count--;
    }

    // 7. Find an element at a specified index
    public T Find(int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException(nameof(index));

        ListNode<T> current = head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }

        return current.Value;
    }
    
    // Get the count of elements in the list
    public int Count()
    {
        return count;
    }
}

// Example usage
public class Program
{
    public static void Main()
    {
        MyList<int> myList = new MyList<int>();

        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        Console.WriteLine("Count: " + myList.Count()); // Output: 3

        Console.WriteLine("Element at index 1: " + myList.Find(1)); // Output: 2

        myList.InsertAt(4, 1);
        Console.WriteLine("Element at index 1 after insertion: " + myList.Find(1)); // Output: 4

        Console.WriteLine("Contains 3: " + myList.Contains(3)); // Output: True

        myList.DeleteAt(2);
        Console.WriteLine("Element at index 2 after deletion: " + myList.Find(2)); // Output: 3

        myList.Clear();
        Console.WriteLine("Count after clear: " + myList.Count()); // Output: 0
    }
}
