using static System.Console;
//creating 2 delegates
delegate int Alpha(int n);
delegate void Bravo(string t);
//creating a class
class myClass
{
    //creating a number field
    public int number;
    //creating a constructor that assigns the value of the field
    public myClass(int n)
    {
        number = n;
    }
    //creating a method that returns an Alpha instance
    public Alpha method;
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating 2 class objects
        myClass A = new myClass(100);
        myClass B = new myClass(200);

        //assigning the method A.method to lambda expression
        A.method = n => A.number + n;//returns the summation
        //assigning the method B.method to lambda expression
        B.method = (int n) =>
        {
            //returns the summation
            return B.number + n;
        };

        //creating a variable and assigning its value
        int x = 80;
        //displaying the method A.method
        WriteLine("A.method({0}) = {1}", x, A.method(x));
        //assigning the fields value
        A.number = 300;
        //displaying the method A.method
        WriteLine("A.method({0}) = {1}", x, A.method(x));
        //displaying the method B.method
        WriteLine("B.method({0}) = {1}", x, B.method(x));

        //creating a delegate variable
        Bravo show;
        //assigning the d.v's value to a lambda expression
        show = t => WriteLine("Text: \"{0}\"", t);
        //using the d.v
        show("Bravo");

        //assigning the d.v's value to a lambda expression
        show = (string t) =>
        {
            //creating a loop that repeats t.length times
            for (int i = 0; i < t.Length; i++)
            {
                //displaying the element of the string
                Write("|" + t[i]);
            }
            WriteLine("|");
        };
        //using the d.v
        show("Bravo");


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}