namespace Assignment3.Color;

public class Ball
{
    public int Size { set; get; }
    public Color Color { set; get; }
    public int ThrowCount { set; get; }
    
    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
        ThrowCount = 0;
    }
    
    public void Pop()
    {
        Size = 0;
    }
    
    public void Throw()
    {
        if (Size > 0)
        {
            ThrowCount++;
        }
    }
    
    public int GetThrowCount()
    {
        return ThrowCount;
    }
}