using static System.Console;
//creating a delegate
delegate void myDelegate(string txt);
//creating a class
class myClass
{
    //creating a private delegate field
    private myDelegate myevent;
    //creating an event that returns a delegate
    public event myDelegate myEvent
    {
        //defining an add accessor
        add
        {
            //adding to the delegate the value of the assignment
            myevent += value;
        }
        //defining a remove accessor
        remove
        {
            //removing from the delegate the value of the assignment
            myevent -= value;
        }
    }
    //creating a method
    public void RaiseMyEvent(string txt)
    {
        //id the delegate isn't empty
        if (myevent != null)
        {
            //using the delegate
            myevent(txt);
        }
    }
}
//creating a class
class Alpha
{
    //creating a public string field
    public string name;
    //creating a constructor that assigns the value of the field
    public Alpha(string n)
    {
        name = n;
    }
    //creating a public method
    public void show(string msg)
    {
        //displaying the field and the argument of the method
        WriteLine("Object " + name + ":");
        WriteLine(msg);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating three class objects
        myClass obj = new myClass();
        Alpha A = new Alpha("A");
        Alpha B = new Alpha("B");

        //using the evoking method from obj
        obj.RaiseMyEvent("First event");

        //adding to myEvent the method show from A
        obj.myEvent += A.show;
        //using the evoking method from obj
        obj.RaiseMyEvent("Second event");
        WriteLine();

        //adding to myEvent the method show from B
        obj.myEvent += B.show;
        //using the evoking method from obj
        obj.RaiseMyEvent("Third event");
        WriteLine();

        //removing from myEvent the method show from A
        obj.myEvent -= A.show;
        //using the evoking method from obj
        obj.RaiseMyEvent("Fourth event");
        WriteLine();obj.myEvent -= A.show;

        //removing from myEvent the method show from and B
        obj.myEvent -= B.show;
        //using the evoking method from obj
        obj.RaiseMyEvent("Fifth event");

        //creating a delegate instance and assigning its value to the method A from show
        myDelegate md = A.show;
        //adding to the delegate the method show from B
        md += B.show;
        //adding the delegate to myEvent
        obj.myEvent += md;
        obj.RaiseMyEvent("Sixth event");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}