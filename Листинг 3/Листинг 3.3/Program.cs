using static System.Console;
//creating a struct
struct myStruct
{
    //creating an char array
    public char[] symbs;
    //creating a method that displays the contents of the array
    public void show()
    {
        for (int i = 0; i < symbs.Length; i++)
        {
            Write("|" + symbs[i]);
        }
        WriteLine("|");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating 2 struct variable
        myStruct A, B;
        //assigning the field of A
        A.symbs = new char[7];
        //creating a loop that assigns the contents of the array
        for (int i = 0; i < A.symbs.Length; i++)
        {
            //assigns the index to the summation of 'A' and i converted to char
            A.symbs[i] = (char)('A' + i);
        }

        //using the method show form A
        WriteLine("Instance A: ");
        A.show();
        //assigning the value of B to the value of A
        B = A;

        WriteLine("Instance B: ");
        //using the method show form B
        B.show();


        //assigning the first and last elements of the array
        A.symbs[0] = 'X';
        B.symbs[B.symbs.Length - 1] = 'Y';
        WriteLine("Instance A: ");
        A.show();
        //using the methods show from A and B
        WriteLine("Instance B: ");
        B.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}