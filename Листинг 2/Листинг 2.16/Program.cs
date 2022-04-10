using static System.Console;
delegate void myDelegate(string txt);
class myClass
{
    public event myDelegate myEvent;
    public void RaiseMyEvent(string txt)
    {
        if (myEvent != null)
        {
            myEvent(txt);
        }
    }
}
class Alpha
{
    public string name;
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

        obj.RaiseMyEvent("First message");
        obj.myEvent += A.show;

        obj.RaiseMyEvent("Second event");
        WriteLine();

        obj.myEvent += B.show;
        obj.RaiseMyEvent("Third event");
        WriteLine();

        obj.myEvent -= A.show;
        obj.RaiseMyEvent("Fourth event");
        WriteLine();

        obj.myEvent -= A.show;
        obj.myEvent -= B.show;

        obj.RaiseMyEvent("Fifth event");

        myDelegate md = A.show;
        md += B.show;

        obj.myEvent += md;
        obj.RaiseMyEvent("Sixth event");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}