using static System.Console;
//creating a struct
struct myStruct
{
    //creating a public char array field
    public char[] name;
    //creating a public int field
    public int code;
    //creating a constructor which assigns the value of the fields
    public myStruct(char[] name, int code)
    {
        this.name = name;
        this.code = code;
    }
    //creating a public method with no arguments
    public void show()
    {
        WriteLine("Array:");
        //creating loop that repeats name.Length times
        for (int i = 0; i < name.Length; i++)
        {
            //displays the content of the coresponding index
            Write("|" + name[i]);
        }
        //displays the number field
        WriteLine("|\nNumber field: {0}", code);
        WriteLine();
    }
}
public class Program
{
    //creating a static method with 2 arguments(1 string, 1 int) that returns a struct variable
    static myStruct create(string t, int n)
    {
        //creating a char array and assigning its value to t converted to a char array
        char[] s = t.ToCharArray();
        //creating a struct
        myStruct R = new myStruct(s, n);
        //returns the struct
        return R;
    }
    public static void Main(string[] args)
    {
        //creating a struct
        myStruct A;
        //assigning its value to the outcome of the method create
        A = create("Sigma", 69);
        //using the method show from A
        A.show();

        //creating a struct via the method create and displaying it via its method show
        create("Beta", 101).show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}