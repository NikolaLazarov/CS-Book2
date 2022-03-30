using static System.Console;
//creating a delegate
delegate void myDelegate();
//creating a class
class myClass
{
    //creating a class field
    public string name;
    //creating a constructor
    public myClass(string txt)
    {
        //assigning the fields value to the argument
        name = txt;
    }
    //creating a method
    public void show()
    {
        //displaying the field
        WriteLine(name);
    }
}
public class Program
{
    //creating a method
    static void makeLine()
    {
        //displays - many times :D
        WriteLine("-----------");
    }
    public static void Main(string[] args)
    {
        //creating three class objects
        myClass A = new myClass("Object A");
        myClass B = new myClass("Object B");
        myClass C = new myClass("Object C");

        //creating a delegate object
        myDelegate meth;
        //assigning the delegate to the method show from object A
        meth = A.show;
        //using the delegate
        meth();

        //assigning the value of the delgate
        meth = makeLine;
        //adding to the delegate the method show from the object A
        meth += A.show;
        //adding to the delegate the method show from the object B
        meth += B.show;
        //adding to the delegate the method show from the object C
        meth = meth + C.show;
        //using the delegate
        meth();

        //removing from the delegate the method show from object B
        meth -= B.show;
        //using the delegate
        meth();

        //removing from the delegate the method show from object A
        meth = meth - A.show;
        //using the delegate]
        meth();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}