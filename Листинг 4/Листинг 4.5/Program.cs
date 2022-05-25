using static System.Console;
//creating a class
class _class
{
    //creating a public int field
    public int num;
    //creating a construct that assigns the value of the field
    public _class(int n)
    {
        num = n;
    }
}
public class Program
{
    unsafe static void Main(string[] args)
    {
        //using the fixed function to assign value of the pointer and displaying thy values
        fixed (int* p = &new _class(123).num)
        {
            WriteLine("The value and address of field num: {0,2}\t{1}", (uint)p, *p);
            //assigning the value
            *p = 321;
            WriteLine("The value and address of field num: {0,2}\t{1}", (uint)p, *p);
            WriteLine("End of fixed operator");
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}