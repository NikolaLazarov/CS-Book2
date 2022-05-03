using static System.Console;
//creating a struct
struct myStruct
{
    //creating 2 fields(string, int)
    public string name;
    public int code;
    //creating a constructor which assigns the values of the fields
    public myStruct(string name, int code)
    {
        this.name = name;
        this.code = code;
    }
    /*overloading a ToString method
    The method displays the values of the fields of the struct*/
    public override string ToString()
    {
        string txt = "Instance: \"" + name + "\"\n";
        txt += "Number field: " + code + "\n";
        return txt;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating 2 struct object variables
        myStruct A = new myStruct("Alpha", 100);
        myStruct B = new myStruct("Beta", 200);

        //displaying the struct A
        WriteLine(A);

        //creating a string variable and assigning its value(the struct B is also added)
        string text = B + "The execution of the program is concluded.";
        WriteLine(text);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}