using static System.Console;
abstract class Base
{
    protected int a;
    protected int b;
    public Base(int i, int j)
    {
        a = i;
        b = j;
    }
    public abstract int this[int k]
    {
        get;
    }
}
interface myItf
{
    int meth(int k);
}
class myClass : Base, myItf
{
    int i;
    public myClass(int i, int j) : base(i, j)
    {
        a = i;
        b = j;
    }
    public override int this[int k]
    {
        get
        {
            if (k % 2 == 0)
            {
                i = a;
                return a;
            }
            else
            {
                i = b;
                return b;
            }
        }
    }
    public int meth(int k)
    {
        return i * k;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass(3, 4);
        WriteLine(A[1]);
        WriteLine(A.meth(2));

        WriteLine(A[2]);
        WriteLine(A.meth(2));

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}