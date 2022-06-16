using static System.Console;
//creating a class that inherits from class Exception
class EXCEPTION : Exception
{
    //creating 2 private string fields
    private string time;
    private string source;
    /*creating a constructor with an Exception object as an argument and using the Exception class constructor
     //assigns the values of the 2 string fields
     */
    public EXCEPTION(Exception obj) : base("Error of the class EXCEPTION")
    {
        //assigning the value of source to the name of the accrued exception
        source = obj.GetType().Name;
        //assigning the value of time to the date and time of the moment of compilation of the program
        time = DateTime.Now.ToString();
    }
    //overloading a ToString method
    public override string ToString()
    {
        //creating a string variable and assigning its value to the error message of the exception
        string txt = Message + "\n";
        //adding the value of source and time
        txt += "End class of error: " + source + "\n";
        txt += "Date and hour of generation: " + time;
        //returns txt
        return txt;
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        //defining a try block
        try
        {
            //defining a try block
            try
            {
                //creating an int array with one element
                int[] a = { 1 };
                //assigning the value of the second element of the array
                a[1] = 2;
            }
            //catching an exception from class Exception
            catch (Exception e)
            {
                //creating a new EXCEPTION object
                EXCEPTION me = new EXCEPTION(e);
                //throwing the object as an exception
                throw me;
            }
        }
        //catching an exception from class Exception
        catch (Exception e)
        {
            //displays the value of the class object via the overloaded method
            WriteLine(e);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}