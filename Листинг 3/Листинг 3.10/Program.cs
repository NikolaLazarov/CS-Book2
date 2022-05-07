using static System.Console;
//creating a delegate
delegate void myDelegate(string t);
//creating a struct
struct Alpha
{
    //creating a public string field
    public string name;
    //creating a private delegate field; 
    private myDelegate myevent;
    //creating a public event
    public event myDelegate _myEvent
    {
        //defining an add accessor
        add
        {
            myevent += value;
        }
        //defining a remove accessor
        remove
        {
            myevent -= value;
        }
    }
    //creating constructor that assigns the values of the field
    public Alpha(string t)
    {
        name = t;
        myevent = null;
    }
    //creating a method which evokes the event if it isnt null
    public void _ee()
    {
        if (myevent != null) myevent("Alpha: " + name);
    }
}
struct Bravo
{
    //creating a public string field
    public string name;
    //creating an event
    public event myDelegate _Event;
    //creating a method that evokes the event if its isnt null
    public void _ee()
    {
        if (_Event != null) _Event("Bravo: " + name);
    }
}
public class Program
{
    //creating a static method
    static void show(string t)
    {
        //displaying shit idk
        WriteLine("An event appears.");
        WriteLine(t);
        WriteLine("-----------------------");
    }
    public static void Main(string[] args)
    {
        //creating a struct object
        Alpha A = new Alpha("Instance A");
        //adding to its event the method show
        A._myEvent += show;
        //evoking the event
        A._ee();

        //creating a struct object
        Bravo B = new Bravo();
        //assigning the value of its string field
        B.name = "Instance B";
        //adding to its event the method show
        B._Event += show;
        //evoking the event
        B._ee();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}