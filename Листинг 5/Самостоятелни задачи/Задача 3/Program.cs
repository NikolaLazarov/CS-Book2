using static System.Console;
public class Program
{
    static string solve(double A, double B)
    {
        string msg;
        if (B % A == 0 || A == 0 && B == 0) return msg = "There is a solution.";
        else msg = "There isn't a solution";
        throw new ArithmeticException(msg);
    }
    public static void Main(string[] args)
    {
        try
        {
            Write("Enter A: ");
            double A = Int32.Parse(ReadLine());
            Write("Enter B: ");
            double B = Int32.Parse(ReadLine());
            WriteLine(solve(A, B));
        }
        catch (ArithmeticException e)
        {
            WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            WriteLine(e.Message);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}