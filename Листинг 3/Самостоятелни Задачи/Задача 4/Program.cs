using static System.Console;
struct _struct
{
    private int[] arrNums;
    public _struct(int a)
    {
        arrNums = new int[a];
        Random rnd = new Random();
        for (int i = 0; i < arrNums.Length; i++)
        {
            arrNums[i] = rnd.Next(1, 9);
        }
    }
    public void disArr()
    {
        for (int i = 0; i < arrNums.Length; i++)
        {
            Write(arrNums[i] + " ");
        }
        WriteLine();
    }
    public int max()
    {
        int n = arrNums[0];
        for (int i = 1; i < arrNums.Length; i++)
        {
            if (n < arrNums[i])
            {
                n = arrNums[i];
            }
        }
        return n;
    }
    public int min()
    {
        int n = arrNums[0];
        for (int i = 0; i < arrNums.Length; i++)
        {
            if (n > arrNums[i])
            {
                n = arrNums[i];
            }
        }
        return n;
    }
    public double avg()
    {
        double n = 0;
        for (int i = 0; i < arrNums.Length; i++)
        {
            n += arrNums[i];
        }
        return n / arrNums.Length;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        _struct A = new _struct(5);

        A.disArr();
        WriteLine(A.min());
        WriteLine(A.max());
        WriteLine(A.avg());

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}