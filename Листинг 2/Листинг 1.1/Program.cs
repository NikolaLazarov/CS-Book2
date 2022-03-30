using static System.Console;
//creating a delegate
delegate char myDelegate(int k, string txt);
//creating a class
class myClass
{
    //creating a class field
    public int code;
    //creating a constructor
    public myClass(int n)
    {
        //assigning the value of the field
        code = n;
    }
    //creating a method
    public char getChar(int k, string txt)
    {
        //returns the value of the summation converted to char type
        return (char)(txt[k] + code);
    }
    //creating a method
    public static char getFirst(int k, string txt)
    {
        //returns the element of the string variable
        return txt[k];
    }
}
public class Program
{
    //creating a method
    static char getLast(int k, string txt)
    {
        //returns the element of the index
        return txt[txt.Length - k - 1];
    }
    public static void Main(string[] args)
    {
        //creating a class object
        myClass obj = new myClass(5);
        //creating a delegate object that points to getChar
        myDelegate meth = new myDelegate(obj.getChar);
        //displaying the delegate
        WriteLine("Symbol \' {0} \'", meth(4, "Alpha"));

        //assigning a value to the field of myClass
        obj.code = 1;
        //displaying the delegate
        WriteLine("Symbol \' {0} \'", meth(4, "Alpha"));

        //assigning the value of meth to the method getFirst from myClass
        meth = myClass.getFirst;
        //displaying the delegate
        WriteLine("Symbol \' {0} \'", meth(2, "Alpha"));

        //assigning the value of meth to the method getLast
        meth = getLast;
        //displaying the delegate
        WriteLine("Symbol \' {0} \'", meth(1, "Alpha"));

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}