namespace Assignment3.Color;

public class Color
{
    public Color(int red, int green, int blue, int alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = 255;
    }
    
    public int Red { set; get; }
    public int Green { set; get; }
    public int Blue { set; get; }
    public int Alpha { set; get; }
    
    public double GetGrayscale()
    {
        return (Red + Green + Blue) / 3.0;
    }
}