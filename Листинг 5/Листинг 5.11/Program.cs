using static System.Console;
//creating a class
class CLASS
{
    //creating a private byte field
    private byte num;
    //creating a property
    public int number
    {
        //defining a get accessor
        get
        {
            //returns the filed
            return num;
        }
        //defining a set accessor
        set
        {
            //defining a try block
            try
            {
                //creating a checked function
                checked
                {
                    //assigning the value of the field to the value of the assignment converted to byte
                    num = (byte)value;
                }
            }
            //catching a OverflowException
            catch (OverflowException)
            {
                //assigns the value of the field
                num = 255;
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a class object
        CLASS obj = new CLASS();
        //assigns the value of the field of the class via property
        obj.number = 100;
        //displays the value of the field of the class via property
        WriteLine("Value of property: " + obj.number);
        //assigns the value of the field of the class via property
        obj.number = 300;
        //displays the value of the field of the class via property
        WriteLine("Value of property: " + obj.number);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}