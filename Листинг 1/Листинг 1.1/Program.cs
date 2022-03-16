using static System.Console;
//creating an abstract class
abstract class Base
{
    //creating a protected variable field
    protected int num;
    //creating a constructor
    public Base(int n)
    {
        //using the set method
        set(n);
    }
    //creating 3 abstract methods
    public abstract void show();
    public abstract void set(int n);
    public abstract int get();
}
//creating a class that inherits from Base
class Alpha : Base
{
    //creating a protected variable field
    protected int val;
    //creating a constructor with a reference to the base class constructor
    public Alpha(int n) : base(n)
    {
        //using the method show
        show();
    }
    //overloading the void method
    public override void show()
    {
        //displaying values from Alpha
        WriteLine("Alpha: {0},{1} и {2}", num, val, get());
    }
    //overloading the set method
    public override void set(int n)
    {
        //assigning the variables value
        num = n;
        //assigning the variables value 
        val = n % 10;
    }
    //overloading a get method
    public override int get()
    {
        //returns the filed divided by 10
        return num / 10;
    }
}
//creating a class that inherits from Alpha
class Bravo : Alpha
{
    //creating a protected field variable
    protected int val;
    //creating a constructor with a reference to the base class
    public Bravo(int n) : base(n)
    {
        //using the method show
        show();
    }
    //overloading the method show
    public override void show()
    {
        //displaying value of Bravo
        WriteLine("Bravo: {0},{1} и {2}", num, val, get());
    }
    //overloading a set method
    public override void set(int n)
    {
        //assigning values to the variables
        num = n;
        val = n % 100;
    }
    //overloading a get method
    public override int get()
    {
        //returns the filed divided by 10
        return num / 100;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a class variable
        Base obj;
        //creating 2 class objects
        Alpha A = new Alpha(123);
        Bravo B = new Bravo(321);

        //assigning the class variables value to the object A
        obj = A;
        WriteLine("След изпълнение на командата obj = A");

        //using the method set form obj
        obj.set(456);
        //using the method show form obj
        obj.show();

        //assigning the class variables value to the object B
        obj = B;
        WriteLine("След изпълнение на командата obj = B");

        //using the method set form obj
        obj.set(654);
        //using the method show form obj
        obj.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}