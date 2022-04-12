using static System.Console;
//creating a delegate
delegate void myDelegate(string txt);
//creating a class
class myClass
{
    //creating an event
    public event myDelegate myEvent;
    //creating a method
    public void RaiseMyEvent(string txt)
    {
        //if the event isn't empty
        if (myEvent != null)
        {
            //trigger the event
            myEvent(txt);
        }
    }
}
//creating a class
class Alpha
{
    //creating a public string field
    public string name;
    //creating a constructor that assigns the value of the field
    public Alpha(string txt)
    {
        name = txt;
    }
    //creating a methos
    public void show(string msg)
    {
        //displaying values
        WriteLine("Object " + name + ":");
        WriteLine(msg);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a class object
        myClass obj = new myClass();

        //creating 2 class objects
        Alpha A = new Alpha("A");
        Alpha B = new Alpha("B");

        //using a method form obj
        obj.RaiseMyEvent("First message");
        //adding to the event a method
        obj.myEvent += A.show;

        //using a method form obj
        obj.RaiseMyEvent("Second event");
        WriteLine();

        //adding to the event a method
        obj.myEvent += B.show;
        //using a method form obj
        obj.RaiseMyEvent("Third event");
        WriteLine();

        //removing to the event a method
        obj.myEvent -= A.show;
        //using a method form obj
        obj.RaiseMyEvent("Fourth event");
        WriteLine();

        
         //removing to the event a method
        obj.myEvent -= A.show;
         //removing to the event a method
        obj.myEvent -= B.show;

        //using a method form obj
        obj.RaiseMyEvent("Fifth event");

        //creating a delegate and assigning its value to a method from A
        myDelegate md = A.show;
        //adding a method to the d.i.
        md += B.show;

        //adding a delegate to the event
        obj.myEvent += md;
        //using a method form obj
        obj.RaiseMyEvent("Sixth event");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
