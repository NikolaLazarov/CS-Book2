using static System.Console;
class CLASS
{
    private int[] num;
    public CLASS(int n)
    {
        num = new int[n];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = i + 1;
        }
    }
    public int this[int k]
    {
        get
        {
            return num.Length;
        }
        set
        {
            num[k] = value;
        }
    }
}
public class Program
{
    static void meth(CLASS obj)
    {
        throw new ArithmeticException("The length of the array is: " + obj[98]);
    }
    public static void Main(string[] args)
    {
        CLASS obj = new CLASS(5);
        try
        {
            meth(obj);
        }
        catch (ArithmeticException e)
        {
            WriteLine(e.Message);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}