using static System.Console;
//creating an interface
interface _interface
{
    //creating 2 methods
    void set(int n);
    void show();
}
//creating a struct that inherits from _interface
struct _struct : _interface
{
    //creating a private int field
    private int code;
    //creating a public method that assigns the value of the field
    public void set(int n)
    {
        code = n;
    }
    //creating a method that outputs the value of the field
    public void show()
    {
        WriteLine("Number field: " + code);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a struct variable
        _struct A = new _struct();
        //using the method set to assign the value of _struct's field via the method set
        A.set(100);
        //outputing the value of the field
        WriteLine("Insatence A: ");
        A.show();

        //creating an interface variable
        _interface R;
        //assigning the value of R to A
        R = A;
        //outputting R's field value
        WriteLine("Variable R: ");
        R.show();
        //assigning the value of R's field via the method set
        R.set(200);
        //outputting R's field value
        WriteLine("Variable R: ");
        R.show();

        //outputting A's field value
        WriteLine("Instance A: ");
        A.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}