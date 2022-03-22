using static System.Console;
abstract class Base
{
    protected int[] arrNums;
    public Base(int n)
    {
        arrNums = new int[n];
    }
    public abstract int length
    {
        get;
    }
    public abstract int this[int n]
    {
        get;
        set;
    }
    public abstract void show();
}
class myClass : Base
{
    public myClass(int n) : base(n)
    {
        arrNums = new int[n];
    }
    public override int length
    {
        get
        {
            return arrNums.Length;
        }
    }
    public override int this[int n]
    {
        get
        {
            return arrNums[n];
        }
        set
        {
            arrNums[n] = value;
        }
    }
    public override void show()
    {
        for (int i = 0; i < arrNums.Length; i++)
        {
            Write(arrNums[i] + " ");
        }
        WriteLine();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass(5);

        WriteLine(A.length);
        A[0] = 6;
        A[1] = 9;
        A[2] = 4;
        A[3] = 2;
        A[4] = 0;
        A.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
