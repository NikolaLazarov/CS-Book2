using static System.Console;
using System.Threading;
class _class
{
    public int[] arrNums;
    public char[] arrSymbs;
    public _class(int[] arr, char[] arrr)
    {
        arrNums = arr;
        arrSymbs = arrr;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] arrNum = new int[5];
        char[] arrSymb = new char[5];
        _class obj = new _class(arrNum, arrSymb);
        Thread A = new Thread(() =>
        {
            for (int i = 0; i < obj.arrNums.Length; i++)
            {
                obj.arrNums[i] = i + 1;
            }
        });
        Thread B = new Thread(() =>
        {
            for (int i = 0; i < obj.arrSymbs.Length; i++)
            {
                obj.arrSymbs[i] = (char)(i + 65);
            }
        });
        A.Start();
        B.Start();

        for (int i = 0; i < arrNum.Length; i++)
        {
            Thread.Sleep(100);
            Write(obj.arrNums[i] + " ");
        }
        WriteLine();
        for (int i = 0; i < arrSymb.Length; i++)
        {
            Thread.Sleep(100);
            Write(obj.arrSymbs[i] + " ");
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}