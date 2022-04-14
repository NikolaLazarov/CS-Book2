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
        myDelegate[] delegates = new myDelegate[3];
        for(int i = 0; i < objs.Length; i++){
            Random rnd = new Random();
            delegates[i] = objs[i].set;
            delegates[i]((char)rnd.Next(65,91));
        }
        for(int i = 0; i < objs.Length; i++){
            WriteLine(delegates[i]);
        }
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}