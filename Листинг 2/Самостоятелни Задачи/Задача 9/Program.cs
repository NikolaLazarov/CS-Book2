using static System.Console;
public class Program
{
    static string WalterHWhite(params double[] args)
    {
        double x1 = (-args[1] + Math.Sqrt(Math.Pow(args[1],2) - 4 * args[0] * args[2])) / 2;
        double x2 = (args[1] + Math.Sqrt(Math.Pow(args[1],2) - 4 * args[0] * args[2])) / 2;
        string qF = args[0] + "x² +" + args[1] + "x + " + args[2] + " = x1 = " + x1 + "/x2 = " + x2;
        return qF;
    }
    public static void Main(string[] args)
    {
        WriteLine(WalterHWhite(1, -11, 28));

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
