using static System.Console;
//creating an abstract class
abstract class Base
{
    //creating an abstract property
    public abstract char symbol
    {
        //defining a get accessor
        get;
    }
    //creating an abstract indexer
    public abstract int this[int k]
    {
        //defining a get accessor
        get;
    }
    //creating an abstract method
    public abstract void show();
}
//creating an interface
interface First
{
    //creating a property
    char symbol
    {
        //defining a get accessor
        get;
    }
    //creating an indexer
    int this[int k]
    {
        //defining a get accessor
        get;
    }
    //creating a method
    void show();
}
//creating an interface
interface Second
{
    //creating a property
    char symbol
    {
        //defining a get accessor
        get;
    }
    //creating an index
    int this[int k]
    {
        //defining a get accessor
        get;
    }
    //creating a method
    void show();
}
//creating a class that inherits from a class and interfaces
class myClass : Base, First, Second
{
    //creating a variable field
    private char smb;
    //creating a constructor
    public myClass(char s) : base()
    {
        //assigning the fields value to the arguments
        smb = s;
    }
    //overloading a property
    public override char symbol
    {
        //defining a get accessor
        get
        {
            //returns the field
            return smb;
        }
    }
    //creating property from First
    char First.symbol
    {
        //defining a get accessor
        get
        {
            //returns the field + 1 converted to char type 
            return (char)(smb + 1);
        }
    }
    //overloading an indexer
    public override int this[int k]
    {
        //defining a get accessor
        get
        {
            //returns the summation of the field + the argument
            return smb + k;
        }
    }
    //creating indexer from Second
    int Second.this[int k]
    {
        //defining a get accessor
        get
        {
            //returns the subtraction of the field and the argument
            return smb - k;
        }
    }
    //overloading a method
    public override void show()
    {
        //defining the field
        WriteLine("Базов клас Base:\t\'{0}\'", symbol);
    }
    //creating a method from First
    void First.show()
    {
        //defining the field
        WriteLine("Интерфейс First:\t\'{0}\'", symbol);
    }
    //creating a method from Second
    void Second.show()
    {
        //defining the field
        WriteLine("Интерфейс Second:\t\'{0}\'", symbol);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a class object
        myClass obj = new myClass('A');
        //creating an interface variable and assigning its value to obj
        First A = obj;
        //creating an interface variable and assigning its value to obj
        Second B = obj;

        //using the method show in 2 different ways
        obj.show();
        A.show();
        B.show();

        //displaying via property
        WriteLine("obj.symbol=\'{0}\'", obj.symbol);
        WriteLine("  A.symbol=\'{0}\'", A.symbol);
        WriteLine("  B.symbol=\'{0}\'", B.symbol);

        //displaying via indexer
        WriteLine("obj[10]={0}", obj[10]);
        WriteLine("  A[10]={0}", A[10]);
        WriteLine("  B[10]={0}", B[10]);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}