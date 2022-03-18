using static System.Console;
//creating an interface
interface First
{
    //creating a property
    int number
    {
        //defining a get accessor
        get;
        //defining a set accessor
        set;
    }
    //creating an indexer
    int this[int k]
    {
        //defining a get accessor
        get;
    }
}
//creating an interface
interface Second
{
    //creating a method
    void setNum(int n);
    //creating a method
    int getNum();
}
//creating an interface that inherits from two other interfaces
interface myInterface : First, Second
{
    //creating a method
    void show();
}
//creating a method that inherits from an interface
class myClass : myInterface
{
    //creating a variable field
    public int num;
    //creating an constructor
    public myClass(int n)
    {
        //assigning a value via property
        number = n;
        //using the method show
        show();
    }
    //creating a method
    public void show()
    {
        //displays the value of the field vie a property
        WriteLine("Property number = " + number);
    }
    //creating a method
    public void setNum(int n)
    {
        //assigns value to the field
        num = n;
    }
    //creating a method
    public int getNum()
    {
        //returns the value of the field
        return num;
    }
    //creating a property
    public int number
    {
        //defining a get accessor
        get
        {
            //returns the method getNums
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
        //defining a get accesspr
        get
        {
            //creating and assigning a value to a variable
            int r = number;
            //creating a for loop
            for (int i = 0; i < k; i++)
            {
                //dividing the value of the variable by 10
                r /= 10;
            }
            //returns the value of the field divided with ostatuk by 10
            return r % 10;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating and assigning a value to a variable
        int m = 9;
        //creating a class object
        myClass obj = new myClass(12345);
        //creating a for loop
        for (int i = 0; i <= m; i++)
        {
            //displays the elemnts of the objects
            Write("|" + obj[m - i]);
        }
        WriteLine("|");

        WriteLine("Press any key to close...");
    }
}