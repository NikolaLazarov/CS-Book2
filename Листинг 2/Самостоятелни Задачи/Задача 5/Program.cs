using static System.Console;
delegate int myDelegate();
public class Program
{

    public static void Main(string[] args)
    {
        int a = 0, b = 1;
        myDelegate md = () =>
        {
            b += a;
            a = b - a;
            return b;
        };

        WriteLine("Fibonacci number: 1 = 1");
        for (int i = 2; i <= 10; i++)
        {
            Write("Fibonacci number: " + i + " = " + md() + "\n");
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}