using static System.Console;
//creating a struct
struct myStruct
{
    //creating a public, whole number filed
    public int code;
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a variable and assigning its value
        int size = 7;
        //creating a myStruct array whose length is the value of the variable size
        myStruct[] A = new myStruct[size];

        //creating a loop that runs A.length times
        //assigns the values of each element of the array and displays them
        for (int i = 0; i < A.Length; i++)
        {
            A[i].code = 2 * i + 1;
            Write("|" + A[i].code);
        }
        WriteLine("|");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}