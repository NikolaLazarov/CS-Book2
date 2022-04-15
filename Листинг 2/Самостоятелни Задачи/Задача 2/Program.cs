using static System.Console;
delegate void myDelegate(char s);
class myClass{
    public char symbol;
    public void set(char s){
        symbol = s;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass[] objs = new myClass[3];
        myDelegate md = objs[0].set;
        for(int i = 1; i < objs.Length; i++){
            md += objs[i].set;
        }
        md('A');
        for(int i = 0; i < objs.Length; i++){
            WriteLine(objs[i].symbol);
        }
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
