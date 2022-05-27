using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        //creating 2 variables from type int
        int A,B;
        //creating an int type pointer
        int* p;
        //creating a double pointers
        int** q;

        //assigning the address of p to q;
        q = &p;
        //assigning the address of p to A
        p = &A;

        //assigning the value of q
        **q = 123;
        //displaying A
        WriteLine(A);
        //assigning the address of B to q;
        *q = &B;

        //assigning the value of q    
        *p = 321;
        //displaying B
        WriteLine(B);
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}