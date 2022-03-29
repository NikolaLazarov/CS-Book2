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
    public myClass(string t)
    {
        this.t = t;
    }
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
            char[] strings = t.ToCharArray();
            strings[k] = value;
            t = "";
            for (int i = 0; i < strings.Length; i++)
            {
                t += strings[i];
            }
        }
    }
    char myItf1.this[int k]
    {
        get
        {
            return t[k];
        }
        set
        {
            char[] strings = t.ToCharArray();
            strings[k] = value;
            t = "";
            for (int i = 0; i < strings.Length; i++)
            {
                t += strings[i];
            }
        }
    }
    char myItf2.this[int k]
    {
        get
        {
            return t[k];
        }
        set
        {
            char[] strings = t.ToCharArray();
            strings[k] = value;
            t = "";
            for (int i = 0; i < strings.Length; i++)
            {
                t += strings[i];
            }
        }
    }
    public override void show()
    {
        WriteLine(a + "\n" + t);
    }
    void myItf1.show()
    {
        WriteLine(a + "\n" + t);
    }
    void myItf2.show()
    {
        WriteLine(a + "\n" + t);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass("Shampoo");

        obj.number = 69;
        WriteLine(obj.number);
        obj[4] = '♥';
        WriteLine(obj[4]);
        obj.show();

        myItf1 obj1 = obj;
        obj1.number = 420;
        WriteLine(obj1.number);
        obj1[3] = '{';
        WriteLine(obj1[3]);
        obj1.show();

        myItf2 obj2 = obj;
        obj2.number = 65;
        WriteLine(obj2.number);
        obj2[5] = '?';
        WriteLine(obj2[5]);
        obj2.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}