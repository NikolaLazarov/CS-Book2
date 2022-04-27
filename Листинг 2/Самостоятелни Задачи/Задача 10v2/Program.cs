using static System.Console;
delegate void myDelegate(string txt);
class myClass
{
    public myDelegate myevent;
    public event myDelegate myEvent
    {
        add
        {
            myevent += value;
        }
        remove
        {
            myevent -= value;
        }
    }
    public void evoke(string msg)
    {
        if (myevent != null)
        {
            myevent(msg);
        }
    }
}
class Alpha
{
    private string name;
    public Alpha(string txt)
    {
        name = txt;
    }
    public void show(string msg)
    {
        WriteLine("Object " + name + ":");
        WriteLine(msg);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass();
        Alpha A = new Alpha("A");
        Alpha B = new Alpha("B");

        myDelegate md = A.show;
        md += B.show;
        obj.myEvent += md;
        obj.evoke("Lifting straps");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
