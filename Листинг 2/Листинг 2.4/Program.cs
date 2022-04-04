using static System.Console;
//creating a delegate
delegate int myDelegate(int n);
public class Program
{
    //creating 3 methods
    static int f(int n){
        //returns the value of the argument multiplied by 2 and added 1
        return 2*n+1;
    }
    static int g(int n){
        //returns the value of the argument multiplied by 2
        return 2*n;
    }
    static int h(int n){
        //returns the value of the argument multiplied by itself
        return n*n;
    }
    //creating a method
    static void display(myDelegate F,int a,int b){
        WriteLine("{0,-4} | {1,4}","x","F(x)");
        WriteLine("----------");
        //creating a loop that runs b times
        for(int k = a; k <= b; k++){
            //display the elements
            WriteLine("{0,-4} | {1,4}",k,F(k));
        }
        WriteLine();
    }
    public static void Main(string[] args)
    {
        //creating and assigning a values of variables
        int a = 1, b = 5;
        WriteLine("Odd numbers: ");
        //using the method display
        display(f,a,b);

        WriteLine("Even numbers: ");
        //using the method display
        display(g,a,b);

        WriteLine("The number squared: ");
        //using the method display
        display(h,a,b);
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}