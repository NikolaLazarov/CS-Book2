using static System.Console;
delegate int myDelegate(int n);
public class Program
{
    static  int meth(myDelegate md1, myDelegate md2){
       return md1(md2);
    }
    static int meth1(int n){
        return n*n;
    }
    static int meth2(int n){
        return n*n*n;
    }
    public static void Main(string[] args)
    {
        myDelegate md = meth(meth1,meth2);
        WriteLine(md);
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}