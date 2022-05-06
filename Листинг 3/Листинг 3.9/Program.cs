using static System.Console;
//creating a struct
struct myNum
{
    //creating a private int field
    private int number;
    //creating a constructor that assigns the value of the field
    public myNum(int n)
    {
        number = n;
    }
    /*creating an operand that returns the summation of the struct variables
    number field and a whole number*/
    public static int operator +(myNum A, int n)
    {
        return !A + n;
    }
    /*creating an operand that returns the summation of a whole number and a struct variables
    number field*/
    public static int operator +(int n, myNum A)
    {
        return A + n;
    }
    /*creating an operand that returns the summation of the struct variables
    number fields*/
    public static int operator +(myNum A, myNum B)
    {
        return !A + !B;
    }
    //creating an operand that returns the struct variables number field
    public static int operator !(myNum A)
    {
        return A.number;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating 2 struct variables
        myNum A = new myNum(100);
        myNum B = new myNum(200);

        //using the operands
        WriteLine("A: {0}", !A);
        WriteLine("B: {0}", !B);
        WriteLine("A+B: {0}", A + B);
        WriteLine("A + 10: {0}", A + 10);
        WriteLine("20 + B: {0}", 20 + B);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}