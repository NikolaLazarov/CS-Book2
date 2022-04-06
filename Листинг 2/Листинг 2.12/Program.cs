using static System.Console;
//creating a delegate
delegate char myDelegate(int n);
//creating a class
class myClass
{
    //creating a character field
    public char symbol;
    //creating a delegate field
    public myDelegate get;
    //creating a constructor that assigns values to the field
    public myClass(char s, myDelegate md)
    {
        symbol = s;
        get = md;
    }
    //creating a method
    public void set(myDelegate md)
    {
        //assigns the delegate field to the argument
        get = md;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a class object
        myClass obj = new myClass('K', n => (char)('A' + n));
        //displaying and using the method set
        WriteLine("Symbol: \'{0}\'", obj.get(3));

        //using the method set with an argument as lambda expression
        obj.set(n => (char)(obj.symbol + n));
        //displaying and using the method set
        WriteLine("Symbol: \'{0}\'", obj.get(3));

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}