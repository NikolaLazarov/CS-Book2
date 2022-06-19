 using static System.Console;
public class Program
{
    static string quadratic_formula(double a, double b, double c){
        string msg;
        double D = b*b-4*a*c;
        if(D < 0){
            msg = "There isn't a solustion.";
            throw new ArithmeticException(msg);
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        double x1 = (-1*b + Math.Sqrt(D))/(a*2);
        double x2 = (-1*b - Math.Sqrt(D))/(a*2);
        msg = "The solutions of "+a+"x² + "+b+"x + "+c+": ";
        msg += "\nx1 = "+x1;
        msg += "\nx2 = "+x2;
        return msg;
    }                     
    public static void Main(string[] args)
    {
        try{
            Write("Enter the value of a: ");
            double a = Convert.ToDouble(ReadLine());
            Write("Enter the value of b: ");
            double b = Convert.ToDouble(ReadLine());
            Write("Enter the value of c: ");
            double c = Convert.ToDouble(ReadLine());
            WriteLine(quadratic_formula(a,b,c));
        }
        catch(ArithmeticException e){
            WriteLine(e.GetType().Name);
            WriteLine(e.Message);
        }
        catch(FormatException e){
            WriteLine(e.GetType().Name);
            WriteLine(e.Message);
        }
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}