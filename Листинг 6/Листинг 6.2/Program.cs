using static System.Console;
using System.Threading;
//creating a class
class _class
{
    //creating 2 private int fields and 1 private string field
    int count;
    int time;
    string text;
    //creating a public method
    public void show()
    {
        WriteLine(text + ": Begining.");
        //creating a loop that runds count amount of times
        for (int i = 0; i < count; i++)
        {
            WriteLine(text + "-> " + i);
            //pausing for time amount of time
            Thread.Sleep(time);
        }
        WriteLine(text + ": End.");
    }
    //creating a constructor that assignins the value of the fields
    public _class(int c, int t, string txt)
    {
        count = c;
        time = t;
        text = txt;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        WriteLine("Main thread: Begining.");
        //creating 3 class objects
        _class obj1 = new _class(5, 2000, "Thread #1");
        _class obj2 = new _class(6, 1200, "Thread #2");
        _class obj3 = new _class(8, 1000, "Thread #3");

        //creating 3 objects from Thread
        Thread A = new Thread(obj1.show);
        Thread B = new Thread(obj2.show);
        Thread C = new Thread(obj3.show);

        //starting all of the thread objects
        A.Start();
        B.Start();
        C.Start();
        WriteLine("Main thead: End.");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}