using static System.Console;
//creating a struct
struct _struct
{
    //creating a public int field
    public int code;
    //creating a public method that displays the value of the field
    public void show()
    {
        WriteLine("Field code: {0}", code);
    }
}
public class Program
{
    unsafe static void Main(string[] args)
    {
        //creating 2 struct variables
        _struct A, B;
        //creating a struct pointer
        _struct* p;

        //assigning the value of the pointer to the address of A
        p = &A;
        //assigning the value of code
        p->code = 123;
        //evoking the method show via pointer and directly
        p->show();
        A.show();
        WriteLine("----------------");

        //assigning the value of the pointer to the address of B
        p = &B;
        //assigning the value of code
        p->code = 321;
        //evoking the method show via pointer and directly
        p->show();
        B.show();
        WriteLine("----------------");

        //assigning the value of code
        (*p).code = 456;
        //evoking the method show via pointer and directly
        (*p).show();
        B.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}