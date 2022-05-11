using static System.Console;
struct _struct
{
    private int[] arrNums = new int[3];
    public _struct(int a)
    {
        arrNums[0] = a;
        arrNums[1] = 0;
        arrNums[2] = 0;
    }
    public _struct(int a, int b)
    {
        arrNums[0] = a;
        arrNums[1] = b;
        arrNums[2] = 0;
    }
    public _struct(int a, int b, int c)
    {
        arrNums[0] = a;
        arrNums[1] = b;
        arrNums[2] = c;
    }
    public int prop1
    {
        get
        {
            int i = arrNums[0];
            for (int k = 1; k < arrNums.Length; k++)
            {
                if (i > arrNums[k])
                {
                    i = arrNums[k];
                }
            }
            return i;
        }
        set
        {
            int y = 0;
            for (int i = 0; i < arrNums.Length; i++)
            {
                if (value < arrNums[i])
                {
                    y++;
                }
            }
            if (y == 3)
            {
                int t = arrNums[0];
                int n = 0;
                for (int i = 1; i < arrNums.Length; i++)
                {
                    if (t > arrNums[i])
                    {
                        t = arrNums[i];
                        n = i;
                    }
                    else
                    {
                        n = 0;
                    }
                }
                arrNums[n] = value;
            }
        }
    }
    public int prop2
    {
        get
        {
            int i = arrNums[0];
            for (int k = 1; k < arrNums.Length; k++)
            {
                if (i < arrNums[k])
                {
                    i = arrNums[k];
                }
            }
            return i;
        }
        set
        {
            int y = 0;
            for (int i = 0; i < arrNums.Length; i++)
            {
                if (value > arrNums[i])
                {
                    y++;
                }
            }
            if (y == 3)
            {
                int t = arrNums[0];
                int n = 0;
                for (int i = 1; i < arrNums.Length; i++)
                {
                    if (t < arrNums[i])
                    {
                        t = arrNums[i];
                        n = i;
                    }
                    else
                    {
                        n = 0;
                    }
                }
                arrNums[n] = value;
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        _struct A = new _struct(3);
        _struct B = new _struct(1, 4);
        _struct C = new _struct(5, 6, 8);

        WriteLine(A.prop1);
        WriteLine(A.prop2);
        WriteLine();
        WriteLine(B.prop1);
        WriteLine(B.prop2);
        WriteLine();
        WriteLine(C.prop1);
        WriteLine(C.prop2);
        WriteLine();

        A.prop1 = 1;
        A.prop2 = 2;
        A.prop2 = 4;
        A.prop2 = 3;

        B.prop1 = 2;
        B.prop2 = 3;

        C.prop1 = 4;
        C.prop2 = 7;

        WriteLine(A.prop1);
        WriteLine(A.prop2);
        WriteLine();
        WriteLine(B.prop1);
        WriteLine(B.prop2);
        WriteLine();
        WriteLine(C.prop1);
        WriteLine(C.prop2);
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}