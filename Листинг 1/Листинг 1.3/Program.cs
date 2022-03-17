using static System.Console;
//creating an interface
interface myInterface
{
    //creating a method
    void show();
    //creating a method
    void setNum(int n);
    //creating a method
    int getNum();
    //creating a property
    int number
    {
        //defining a get accessor
        get;
        //defining a set accessor
        set;
    }
    //creating a index
    int this[int k]
    {
        //defining a get accessor
        get;
    }
}
//creating a class that inherits from an interface
class myClass : myInterface
{
    //creating a variable field
    private int num;
    //creating a constructor
    public myClass(int n)
    {
        //assigning the fields value
        number = n;
        //using the method show
        show();
    }
    //creating a method
    public void show()
    {
        //displaying a value via property
        WriteLine("Property number: " + number);
    }
    //creating a method
    public void setNum(int n)
    {
        //assigning the fields value
        num = n;
    }
    //creating a method
    public int getNum()
    {
        //returning the field
        return num;
    }
    //creating a property
    public int number
    {
        //defining a get accessor
        get
        {
            //returning a method
            return getNum();
        }
        //defining a set accessor
        set
        {
            //using the method
            setNum(value);
        }
    }
    //creating an indexer
    public int this[int k]
    {
        //defining a get accessor
        get
        {
            //creating a variable and assigning its value
            int r = number;
            //using a for loop
            for (int i = 0; i < k; i++)
            {
                //dividing the value of r by 10
                r /= 10;
            }
            //returns the divion with ostatuk of r and 10
            return r % 10;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a variable and assigning value
        int m = 9;
        //creating a class object
        myClass obj = new myClass(12345);
        //creating a for loop
        for (int i = 0; i <= m; i++)
        {
            //display the element of the object
            Write("|" + obj[m - i]);
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}