using static System.Console;
//creating an interface
interface myInterface
{
    //creating a method
    char getChar(int n);
    //creating an indexer
    char this[int k]
    {
        //defining a get accessor
        get;
    }
}
//creating a class that inherits from an interface
class Alpha : myInterface
{
    //creating a variable field
    private char symb;
    //creating a constructor
    public Alpha(char s)
    {
        //assigning the value of the field
        symb = s;
    }
    //creating a method
    public char getChar(int n)
    {
        //returns the summation of the field and the argument, converted to char
        return (char)(symb + n);
    }
    //creating a indexer
    public char this[int k]
    {
        //defining a get accessor
        get
        {
            //returns the class getChar
            return getChar(k);
        }
    }
}
//creating a class that inherits from an interface
class Bravo : myInterface
{
    //creating a variable field
    private string text;
    //creating a constructor
    public Bravo(string t)
    {
        //assigning the value of the field
        text = t;
    }
    //creating a class
    public char getChar(int k)
    {
        //returns the index of the field
        //the indexer is equal to the argument divided with leftover by the texts lenght
        return text[k % text.Length];
    }
    //creating an indexer
    public char this[int k]
    {
        //defining a get accessor
        get
        {
            //returns the getChar method
            return getChar(k);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating and assigning a value to a variable
        int m = 5;
        //creating an interface variable
        myInterface R;

        //assigning the variables value to a class object
        R = new Alpha('F');
        WriteLine("Символи от \'{0}\' до \'{1}\':", R.getChar(-m), R.getChar(m));
        //creating a for loop
        for(int i = -m; i<= m; i++)
        {
            //displaying elements
            Write("|" + R[i]);
        }
        WriteLine("|");

        //assigning the variables value to a class object
        R = new Bravo("bravo");
        WriteLine("Символи от \'{0}\' до \'{1}\':", R.getChar(0), R.getChar(2 * m + 1));
        //creating a for loop
        for (int i = 0; i <= 2*m+1; i++)
        {
            //displaying elements
            Write("|" + R[i]);
        }
        WriteLine("|");

        WriteLine("Press any key to close...");
    }
}