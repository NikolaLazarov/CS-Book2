using static System.Console;
class NoSuchContentException : Exception
{
    private string ERROR_MESSAGE;
    public NoSuchContentException(string str) : base(str)
    {
        ERROR_MESSAGE = str;
    }
}
public class Program
{
    static int CheckForContent(int[] numArr, int n)
    {
        for (int i = 0; i < numArr.Length; i++)
        {
            if (numArr[i] == n)
            {
                return i;
            }
        }
        throw new NoSuchContentException("There isn't such content in the array.");
    }
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numArr = new int[5];
        for (int i = 0; i < numArr.Length; i++)
        {
            numArr[i] = rnd.Next(1, 9);
        }
        try
        {
            WriteLine(CheckForContent(numArr, 3));
        }
        catch (NoSuchContentException e)
        {
            WriteLine(e.GetType().Name);
            WriteLine(e.Message);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}