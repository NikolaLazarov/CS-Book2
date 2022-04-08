using static System.Console;
//creating a class
class myClass
{
    //creating a private string field
    private string text;
    //creating a constructor that assigns the value of the field
    public myClass(string t)
    {
        text = t;
    }
    //creating an indexer with an lambda accessor
    public char this[int k] => text[k];
    //creating a property with a lambda accessor
    public int length => text.Length;
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a class object
        myClass obj = new myClass("Alpha");
        //creating a loop that repeats obj.length times
        for (int i = 0; i < obj.length; i++)
        {
            //displaying the indexer
            Write("|" + obj[i]);
        }
        WriteLine("|");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}