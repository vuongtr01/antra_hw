namespace Assignment4;

public class MyStack <T>
{
    private List<T> element = new List<T>();

    public int Count()
    {
        return element.Count;
    }

    public T Pop()
    {
        if (Count() == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T value = element[Count() - 1];
        element.RemoveAt(Count() - 1);

        return value;
    }

    public void Push(T newItem)
    {
        element.Add(newItem);
    }
}