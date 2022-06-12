using static System.Console;
class CLASS
{
    private int[] nums;
    public CLASS(int size)
    {
        nums = new int[size];
    }
    public int this[int k]
    {
        get
        {
            return nums[k];
        }
        set
        {
            nums[k] = value;
        }
    }
}
public class Program
{
    static void show(CLASS OBJECT)
    {
        int k = 0;
        try
        {
            while (true)
            {
                Write("|" + OBJECT[k]);
                k++;
            }
        }
        catch (IndexOutOfRangeException)
        {
            WriteLine("|");
        }
    }
    public static void Main(string[] args)
    {
        CLASS OBJECT = new CLASS(10);
        int k = 0;
        try
        {
            do
            {
                OBJECT[k] = 2 * k + 1;
                k++;
            } while (true);
        }
        catch (IndexOutOfRangeException)
        {
            show(OBJECT);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}