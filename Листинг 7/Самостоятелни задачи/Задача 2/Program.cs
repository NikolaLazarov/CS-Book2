using static System.Console;
class Program
{
    static void meth<T>(T[] arr)
    {
        foreach (var item in arr)
        {
            Write("|" + $"{item}");
        }
        WriteLine("|");
        arr[0] = arr[arr.Length - 1];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        foreach (var item in arr)
        {
            Write("|" + $"{item}");
        }
        WriteLine("|");
    }
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] rndArray = new int[5];
        for (int i = 0; i < rndArray.Length; i++)
        {
            rndArray[i] = rnd.Next(10);
        }
        meth(rndArray);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}