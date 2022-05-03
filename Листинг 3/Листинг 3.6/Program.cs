using static System.Console;
//creating a struct
struct myStruct
{
    //creating a private string field
    private string txt;
    //creating a public string property
    public string text
    {
        //defining a get accessor
        get
        {
            //returns the value of txt
            return txt;
        }
        //defining a set accessor
        set
        {
            //assigns the value of txt
            txt = value;
        }
    }
    //creating a public int property(only accessable for reading)
    public int length => txt.Length;
    //creating a public char indexer
    public char this[int i]
    {
        //defining a get accessor
        get
        {
            //returns the value of the element of the coresponding index
            return txt[i];
        }
        //defining a set accessor
        set
        {
            //creating a char array whose contents are symbols from txt
            char[] s = txt.ToCharArray();
            //assigning the elements value
            s[i] = value;
            //assigning the value of txt to array s converted to string type
            txt = new string(s);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a struct variable and assigning its value
        myStruct A = new myStruct();
        //assigning the value of its field via a property
        A.text = "Alpha";
        //displaying the field via property
        WriteLine(A.text);

        //creating a loop that repeats A.length times
        for (int i = 0; i < A.length; i++)
        {
            //displaying the content of the coresponding element
            Write("|" + A[i]);
        }
        WriteLine("|");

        //assigning the first and last elements of the text field via an indexer
        A[0] = 'a';
        A[A.length - 1] = 'A';

        //displaying the field via property
        WriteLine(A.text);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}