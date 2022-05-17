using static System.Console;
struct A{
    int a;
    public A(int a){
        this.a = a;
    }
    public static B operator + (A C, A F){
        return new B(C.a, F.a);
    }
}
struct B{
    int a, b;
    public int[] arrFields = new int[2];
    public B(int a, int b){
        this.a = a;
        this.b = b;
        arrFields[0] = a;
        arrFields[1] = b;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        A A = new A(7);
        A B = new A(6);
        B C = A + B;
        for(int i = 0; i < C.arrFields.Length; i++){
            Write(C.arrFields[i]);
        }
        WriteLine();
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}