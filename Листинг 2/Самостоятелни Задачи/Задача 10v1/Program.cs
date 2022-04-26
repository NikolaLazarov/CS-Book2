using static System.Console;
delegate void myDelegate(string txt);
class myClass
{
    public event myDelegate myEvent;
    public void evoke(string txt)
    {
        if (myEvent != null)
        {
            myEvent(txt);
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
    public void show(string txt)
    {
        WriteLine("Object " + name + ":");
        WriteLine(txt);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass();
        Alpha A = new Alpha("A");
        Alpha B = new Alpha("B");

        obj.myEvent += A.show;
        obj.evoke("Fowl burger");
        WriteLine();
        
        obj.myEvent += B.show;
        obj.evoke("Double filet burger");
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}