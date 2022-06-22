using static System.Console;
class CLASS
{
    private byte n;
    public int number
    {
        get
        {
            return n;
        }
        set
        {
            try
            {
                checked
                {
                    n = (byte)value;
                }
            }
            catch (ArithmeticException)
            {
                n = 255;
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        CLASS obj = new CLASS();
        obj.number = 165;
        WriteLine(obj.number);
        obj.number = 256;
        WriteLine(obj.number);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}