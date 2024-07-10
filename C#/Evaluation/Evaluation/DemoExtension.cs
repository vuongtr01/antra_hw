namespace Evaluation;

public static class DemoExtension
{
    //two number get larger
    static int getLarger(this int a, int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}

//Employee: