using static System.Console;
//creating a struct
struct myStruct
{
    //creating 2 public fields(types: int,string)
    public int code;
    public string name;
    //creating a construct that assigns the values of the fields
    public myStruct(int code, string name)
    {
        this.code = code;
        this.name = name;
    }
    //creating a public method that displays the values of the fields
    public void show()
    {
        WriteLine("Fields \"{0}\" and {1}", name, code);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a struct variable
        myStruct A;
        //assigning the value of the fields of A
        A.code = 100;
        A.name = "Instance A";
        //using the method show from A
        A.show();

        //creating a struct object
        myStruct B = new myStruct(200, "Instance B");
        //using the method show from b
        B.show();

        //assigning the value of A to the value of B
        A = B;
        //assigning the value of the number field of B
        B.code = 300;
        //using the methods show from A and B
        A.show();
        B.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
