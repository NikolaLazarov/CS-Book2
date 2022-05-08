using static System.Console;
enum weekdays { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
public class Program
{
    static string day(int n)
    {
        string[] wdays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        return wdays[n];
    }
    static void day(int a, int b)
    {
        WriteLine(b - a - 1);
    }
    public static void Main(string[] args)
    {
        weekdays wday = weekdays.Mon;
        for (int i = 0; i < 7; i++)
        {
            WriteLine(day(i));
        }
        WriteLine();
        day(1, 5);
        day(6, 7);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}