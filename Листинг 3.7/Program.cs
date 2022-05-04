using static System.Console;
//creating a struct
struct myStruct
{
    //creating a public char array field
    public char[] name;
    //creating a public int field
    public int code;
    //creating a constructor that assigns the values of the fields
    public myStruct(string t, int code)
    {
        name = t.ToCharArray();
        this.code = code;
    }
}
public class Program
{
    //creating a static method with a struct variable as an argument
    static void show(myStruct A)
    {
        //creating a string variable and assigning its value to the array field of the argument
        string txt = new string(A.name);
        //displaying the fields of the arguments
        WriteLine("Charater array field[{0}]", txt);
        WriteLine("Number field: " + A.code);
    }
    //creating a static method with 2 struct variables, int variable and a char variable as arguments
    static void maker(myStruct A, ref myStruct B, int i, char s)
    {
        //showing the struct variables in their original form via the method show
        WriteLine("Method maker() is being executed.");
        WriteLine("First argument");
        show(A);

        WriteLine("Second argument");
        show(B);

        //assigning the content of the coresponding index(int argument) of the argument to the char argument
        A.name[i] = s;
        B.name[i] = s;
        //incrementing the value of the int fields of the struct variables
        A.code++;
        B.code++;
        WriteLine();

        //displaying the structs in the changed version via the method show
        WriteLine("First argument");
        show(A);

        WriteLine("Second argument");
        show(B);
        WriteLine();
    }
    public static void Main(string[] args)
    {
        //creating 2 struct variables
        myStruct A = new myStruct("Alpha", 100);
        myStruct B = new myStruct("Beta", 200);

        //using the method maker
        maker(A, ref B, 3, 'R');
        WriteLine("After evoking the method maker()");
        //diplaying the 2 structs via the method show
        WriteLine("First instance");
        show(A);

        WriteLine("Second argument");
        show(B);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}