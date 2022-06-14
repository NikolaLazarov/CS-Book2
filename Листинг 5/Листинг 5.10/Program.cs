using static System.Console;
//creating a class
class CLASS
{
    //creating a private int array
    private int[] nums;
    //creating a constructor that creates an array
    public CLASS(int size)
    {
        nums = new int[size];
    }
    //creating an indexer
    public int this[int k]
    {
        //defining a get accessor
        get
        {
            //returns the element of the corresponding index
            return nums[k];
        }
        //defining a set accessor
        set
        {
            //assigns the element of the corresponding index
            nums[k] = value;
        }
    }
}
public class Program
{
    //creating a static method with a class object as an argument
    static void show(CLASS OBJECT)
    {
        //creating a variable and assigning its value
        int k = 0;
        //defining a try block
        try
        {
            //creating a while loop that loops forever
            while (true)
            {
                //displaying the element of the corresponding index
                Write("|" + OBJECT[k]);
                k++;
            }
        }
        //catching an IndexOutOfRangeException
        catch (IndexOutOfRangeException)
        {
            WriteLine("|");
        }
    }
    public static void Main(string[] args)
    {
        //creating a class object
        CLASS OBJECT = new CLASS(10);
        //creating a variable and assigning its value
        int k = 0;
        //defining a try block
        try
        {
            //creating a do while loop that runs forever
            do
            {
                //assigning the element of the corresponding index to an odd number
                OBJECT[k] = 2 * k + 1;
                k++;
            } while (true);
        }
        //catching an IndexOurOfRangeException
        catch (IndexOutOfRangeException)
        {
            //using the method show
            show(OBJECT);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}