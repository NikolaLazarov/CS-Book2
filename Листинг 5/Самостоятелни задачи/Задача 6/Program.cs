using static System.Console;
public class Program
{
    static void meth(int n)
    {
        if (n % 2 == 0)
        {
            throw new ArithmeticException("The integer is even ▲");
        }
        else throw new OverflowException("The integer is odd ▼");
    }
    public static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Write("Enter an integer: ");
            int n = Int32.Parse(ReadLine());
            try
            {
                meth(n);
            }
            catch (OverflowException e)
            {
                WriteLine(e.GetType().Name);
                WriteLine(e.Message);
            }
            catch (ArithmeticException e)
            {
                WriteLine(e.GetType().Name);
                WriteLine(e.Message);
            }
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}