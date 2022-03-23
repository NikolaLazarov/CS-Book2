using static System.Console;
abstract class Base
{
    public abstract int number
    {
        get;
        set;
    }
    public abstract char this[int k]
    {
        get;
        set;
    }
    public abstract void show();
}
interface myItf1
{
    public abstract int number
    {
        get;
        set;
    }
    public abstract char this[int k]
    {
        get;
        set;
    }
    public abstract void show();
}
interface myItf2
{
    public abstract int number
    {
        get;
        set;
    }
    public abstract char this[int k]
    {
        get;
        set;
    }
    public abstract void show();
}
class myClass : Base, myItf1, myItf2
{
    int a;
    string t = "";
    public override int number
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }
    }
    int myItf1.number
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }
    }
    int myItf2.number
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }
    }
    public override char this[int k]
    {
        get
        {
            return t[k];
        }
        set
        {
            t[k] = value;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}