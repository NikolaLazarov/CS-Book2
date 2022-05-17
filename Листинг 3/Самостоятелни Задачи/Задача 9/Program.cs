using static System.Console;
struct _struct
{
    public static int min;
    public static int max;
    public static int index;
    public static int minn(int[] a)
    {
        min = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
                index = i + 1;
            }
        }
        return min * 100 + index;
    }
    public static int maxx(int[] a)
    {
        max = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                index = i + 1;
            }
        }
        return max * 100 + index;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int[] arrNums = { 1, 2, 3 };
        WriteLine(_struct.minn(arrNums));
        WriteLine(_struct.maxx(arrNums));

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
