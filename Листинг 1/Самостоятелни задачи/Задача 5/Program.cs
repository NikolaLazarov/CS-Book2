using static System.Console;
interface myItf1
{
    char meth(int n);
}
interface myItf2
{
    int meth(char s);
}
class myClass : myItf1, myItf2
{
    public char meth(int n)
    {
        return (char)n;
    }
    public int meth(char s)
    {
        return (int)s;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass();
        WriteLine(obj.meth(69));
        WriteLine(obj.meth('E'));

        myItf1 A = obj;
        WriteLine(A.meth(69));

        myItf2 B = obj;
        WriteLine(B.meth('E'));

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}