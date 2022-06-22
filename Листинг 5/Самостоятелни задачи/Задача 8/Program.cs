using static System.Console;
class EXCEPTION : Exception
{
    char[] arrChars;
    public EXCEPTION(int n)
    {
        char k = 'A';
        arrChars = new char[n];
        for (int i = 0; i < arrChars.Length; i++)
        {
            arrChars[i] = k;
            k++;
        }
    }
    public char this[int k]
    {
        get
        {
            return arrChars[k];
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        EXCEPTION A = new EXCEPTION(6);
        try
        {
            int i = 0;
            while (true)
            {
                Write(A[i]);
                i++;
            }
        }
        catch (IndexOutOfRangeException e)
        {
            WriteLine(e.Message);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}