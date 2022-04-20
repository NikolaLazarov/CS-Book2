using static System.Console;
delegate string myDelegate();
public class Program
{
    public static void Main(string[] args)
    {
        int day = -1;
        string[] weekDays = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        myDelegate md = () =>
        {
            day++;
            if (day > 6) day = 0;
            return weekDays[day];
        };

        for (int i = 0; i < 9; i++)
        {
            Write(md() + "\n");
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}