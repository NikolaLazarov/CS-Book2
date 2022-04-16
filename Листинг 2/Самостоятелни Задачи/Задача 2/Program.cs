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
        int j = 0;
        while(j<3){
            objs[j] = new myClass();
            j++;
        }
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
