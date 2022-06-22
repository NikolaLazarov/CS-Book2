using static System.Console;
class excep1 : Exception
{
    private string ERROR_MESSAGE;
    public excep1(string txt) : base(txt)
    {
        ERROR_MESSAGE = txt;
    }

}
class excep2 : ArithmeticException
{
    private string ERROR_MESSAGE;
    public excep2(string txt) : base(txt)
    {
        ERROR_MESSAGE = txt;
    }
}
class _CLASS
{
    char[] arrChars;
    public _CLASS(int n)
    {
        arrChars = new char[n];
        for (int i = 0; i < arrChars.Length; i++)
        {
            arrChars[i] = (char)(i + 65);
        }
    }
    public char this[int k]
    {
        get
        {
            if (k > arrChars.Length)
            {
                throw new excep1("The index is higher then the length of the array.");
            }
            else if (k < 0)
            {
                throw new excep2("The index is lower then 0");
            }
            return arrChars[k];
        }
        set
        {
            if (k >= arrChars.Length)
            {
                throw new excep1("The index is higher then the length of the array.");
            }
            else if (k < 0)
            {
                throw new excep2("The index is lower then 0");
            }
            arrChars[k] = value;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        _CLASS A = new _CLASS(5);
        try
        {
            A[5] = 'P';
        }
        catch (excep1 e)
        {
            WriteLine(e.Message);
        }
        try
        {
            WriteLine(A[-1]);
        }
        catch (excep2 e)
        {
            WriteLine(e.Message);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}