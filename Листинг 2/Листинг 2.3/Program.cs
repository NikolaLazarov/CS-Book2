using static System.Console;
//creating a delegate
delegate void myDelegate(string txt);
//creating a class
class myClass
{
    //creating a public delegate field
    public myDelegate apply;
    //creating a constructor
    public myClass(myDelegate md)
    {
        //assigning the value of the field
        apply = md;
    }
}
//creating a class
class Alpha
{
    //creating a private field
    private string name;
    //creating a public method
    public void set(string t)
    {
        //assigning the value of the field
        name = t;
    }
    //overloading a ToString method
    public override string ToString()
    {
        //returns the fields value
        return name;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a class object
        Alpha A = new Alpha();
        //creating a class object
        myClass obj = new myClass(A.set);
        //using the delegate from object obj
        obj.apply("Object A");
        //displaying the object 
        WriteLine(A);

        //creating a class object
        Alpha B = new Alpha();
        //assigning the value of the delegate to the method set of B
        obj.apply = B.set;
        //using the delegate
        obj.apply("Object B");
        //displaying the object
        WriteLine(B);

        //adding the method set of A to the delegate
        obj.apply += A.set;
        //using the delegate on both of the methods it points to
        obj.apply("Object X");
        //displaying the objects
        WriteLine(A + " and " + B);

        //removing the method set of B from the delegate
        obj.apply -= B.set;
        //using the delegate
        obj.apply("Object A");
        //displaying the objects
        WriteLine(A + " and " + B);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}