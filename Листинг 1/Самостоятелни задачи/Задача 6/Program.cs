using static System.Console;
interface myItf1
{
    int this[char s]
    {
        get;
    }
}
interface myItf2
{
    char this[int k]
    {
        get;
    }
}
class myClass : myItf1, myItf2
{
    public int this[char s]
    {
        get
        {
            return (int)s;
        }
    }
    public char this[int k]
    {
        get
        {
            return (char)k;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass();

        WriteLine(A['☻']);
        WriteLine(A[9829]);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}