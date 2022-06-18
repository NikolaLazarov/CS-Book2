using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        int[] NUMBER_ARRAY;
        int o = 0;
        try
        {
            Write("Enter the length of an array: ");
            int i = Int32.Parse(ReadLine());
            NUMBER_ARRAY = new int[i];
            do
            {
                NUMBER_ARRAY[o] = o + 1;
                Write(NUMBER_ARRAY[o] + " ");
                o++;
            } while (o < NUMBER_ARRAY.Length);
            WriteLine();
        }
        catch (Exception e)
        {
            WriteLine("Type of exception: " + e.GetType().Name);
            WriteLine("Error message of exception: " + e.Message);
        }
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}