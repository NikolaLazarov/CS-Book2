using static System.Console;
abstract class Base
{
    protected char[] arrSymbs;
    public Base(string t)
    {
        arrSymbs = t.ToCharArray();
    }
    public abstract char getSymb(int n);
    public abstract void meth(int n, char s);
}
interface myItf1
{
    void meth(string t);
    char this[int k]
    {
        get;
        set;
    }
}
class myClass : Base, myItf1
{
    public myClass(string t) : base(t)
    {
        arrSymbs = t.ToCharArray();
    }
    public override char getSymb(int n)
    {
        return arrSymbs[n];
    }
    public override void meth(int n, char s)
    {
        arrSymbs[n] = s;
    }
    public void meth(string t)
    {
        arrSymbs = t.ToCharArray();
    }
    public char this[int k]
    {
        get
        {
            return arrSymbs[k];
        }
        set
        {
            arrSymbs[k] = value;
        }
    }
    public override string ToString()
    {
        string str = "";
        for (int i = 0; i < arrSymbs.Length; i++)
        {
            str += arrSymbs[i] + " ";
        }
        return str;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass("Computer");

        WriteLine(obj);
        WriteLine(obj.getSymb(4));
        obj.meth(2, '☺');
        WriteLine(obj);

        obj.meth("Hamster");
        WriteLine(obj);
        WriteLine(obj[6]);
        obj[3] = 'p';
        WriteLine(obj);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}