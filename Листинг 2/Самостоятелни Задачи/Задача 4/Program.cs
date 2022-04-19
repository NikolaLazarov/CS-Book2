using static System.Console;
delegate int myDelegate(int n);
class myClass
{
    public myDelegate md;
    public myDelegate this[int n]
    {
        get
        {
            return md = i =>
            {
                double d = Math.Pow(n, i);
                return (int)d;
            };
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass();
        int n = obj[2](3);
        WriteLine(n);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}