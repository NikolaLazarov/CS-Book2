using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        //creating a variable and a pointer
        int n;
        int* p;
        //assigning the pointer to the variable
        p = &n;
        //assigning the pointer to a value
        *p = 123;

        //displaying the values
        WriteLine("Value of variable n = {0}", n);
        WriteLine("Value of variable *p = {0}", *p);
        WriteLine("Address of variable n {0}", (uint)p);
        WriteLine();

        //creating a pointer and assigning their values
        byte* q;
        char* s;
        q = (byte*)p;
        s = (char*)p;
        //assigning the value of n
        n = 65601;

        //displaying the values
        WriteLine("Address of pointer p: {0}", (uint)p);
        WriteLine("Address of pointer q: {0}", (uint)q);
        WriteLine("Address of pointer s: {0}", (uint)s);
        WriteLine();

        //displaying the values
        WriteLine("Value of type int: {0}", *p);
        WriteLine("Value of type char: \'{0}\'", *s);
        WriteLine("Value of variable n = {0}", n);
        WriteLine();

        //assigning the value of s
        *s = 'F';
        //displaying the values
        WriteLine("Value of type int: {0}", *p);
        WriteLine("Value of type byte: {0}", *q);
        WriteLine("Value of type char: \'{0}\'", *s);
        WriteLine("Value of variable n = {0}", n);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}