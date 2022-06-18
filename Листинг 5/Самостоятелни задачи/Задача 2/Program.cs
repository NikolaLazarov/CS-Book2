using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        int n = 1;
        while (n <= 5)
        {
            try
            {
                Write("Enter the first number: ");
                int max = Int32.Parse(ReadLine());
                Write("Enter the second number: ");
                int min = Int32.Parse(ReadLine());
                if (max < min)
                {
                    int pivot = max;
                    max = min;
                    min = pivot;
                }
                WriteLine((double)max % min);
            }
            catch (Exception e)
            {
                WriteLine("Type of exception: " + e.GetType().Name);
                WriteLine("Error message of the exception: " + e.Message);
            }
            n++;
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}