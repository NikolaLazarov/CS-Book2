using static System.Console;
//creating an abstract class
abstract class jihad
{
    //creating a property
    public abstract int number
    {
        //defining a get accessor
        get;
        //defining a set accessor
        set;
    }
    //creating a constructor
    public jihad(int n)
    {
        //assigning a value via property
        number = n;
        //using the method show
        show();
    }
    //creating a method
    public void show()
    {
        //display a value via property
        WriteLine("Property number: " + number);
    }
}
//creating an interface
interface First
{
    //creating a method
    void setNum(int n);
    //creating a method
    int getNum();
}
//creating an interface
interface Second
{
    //creating an indexer
    int this[int k]
    {
        //defining a get accessor
        get;
    }
}
//creating a class that inherits form a class and interfaces
class myClass : jihad, First, Second
{
    //creating a variable field
    private int num;
    //creating a constructor
    public myClass(int n) : base(n) { }
    //creating a method
    public void setNum(int n)
    {
        //assigning the fields value
        num = n;
    }
    //creating a method
    public int getNum()
    {
        //returns the fields value
        return num;
    }
    //creating a property
    public override int number
    {
        //defining a get accessor
        get
        {
            //return the method getNum
            return getNum();
        }
        //defining a set accessor
        set
        {
            //using the method setNum
            setNum(value);
        }
    }
    //creating an indexer
    public int this[int k]
    {
        //defining a get accessor
        get
        {
            //creating and assigning a value of a variable
            int r = number;
            //creating a for loop
            for (int i = 0; i < k; i++)
            {
                //dividing the fields value by 10;
                r /= 10;
            }
            //returning the fields value divided by 10 with ostatuk
            return r % 10;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating and assigning a value of a variable
        int m = 9;
        //creating a class object
        myClass obj = new myClass(12345);
        //creating a for loop
        for (int i = 0; i <= m; i++)
        {
            //displays the element of the field
            Write("|" + obj[m - i]);
        }
        WriteLine("|");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}