using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        int Array_Length = 10;
        char[] Char_Array = new char[Array_Length];
        Thread even = new Thread(() =>
        {
            char s = 'A';
            for (int i = 0; i < Array_Length; i += 2)
            {
                Char_Array[i] = s;
                s++;
            }
        });
        Thread odd = new Thread(() =>
        {
            char s = 'А';
            for (int i = 1; i < Char_Array.Length; i += 2)
            {
                Char_Array[i] = s;
                s++;
            }
        });

        even.Start();
        odd.Start();
        for (int i = 0; i < Char_Array.Length; i++)
        {
            Thread.Sleep(250);
            Write(Char_Array[i]);
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}