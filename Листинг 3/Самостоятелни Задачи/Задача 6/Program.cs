using static System.Console;
struct _struct
{
    public int a;
    public int b;
    public _struct(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public static _struct operator +(_struct a, _struct b)
    {
        int f = a.a + b.a;
        int c = a.b + b.b;
        return new _struct(f, c);
    }
    public static _struct operator -(_struct a, _struct b)
    {
        int f = a.a - b.a;
        int c = a.b - b.b;
        return new _struct(f, c);
    }
    public static _struct operator *(_struct a, _struct b)
    {
        int f = a.a * b.a;
        int c = a.b * b.b;
        return new _struct(f, c);
    }
    public static int operator ^(_struct a, _struct b)
    {
        int[] arrNums = { a.a, a.b, b.a, b.b };
        int y = arrNums.Max() * 100 + arrNums.Min();
        return y;
    }
    public override string ToString()
    {
        string str = "";
        str += "Field a: " + a;
        str += "\nField b: " + b;
        str += "\n-------------";
        return str;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            _struct A = new _struct(2, 3);
            _struct B = new _struct(3, 4);
            _struct C = A + B;
            _struct E = A - B;
            _struct G = A * B;
            WriteLine(A);
            WriteLine(B);
            WriteLine(C);
            WriteLine(E);
            WriteLine(G);
            WriteLine(A ^ B);
            WriteLine(E ^ G);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
