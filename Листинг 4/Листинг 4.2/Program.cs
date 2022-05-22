using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        //creating a variable of type double
        double miniarray;
        /*creating a variable of type int and
        assigning its value to the divison of 8 and 1*/
        int m = sizeof(double) / sizeof(byte);
        //creating a pointer of no tpye
        void* pnt;
        //assigning its value to miniarray
        pnt = &miniarray;
        //creating a pointer of type byte
        byte* p;
        //assigning its value to the value of pnt converted to byte pointer
        p = (byte*)pnt;

        //creating a for loop that runs m-1 times
        for (int i = 0; i < m; i++)
        {
            //assigns the value of the i block of p the summation of i and 1 converted to p
            p[i] = (byte)(i + 1);
            //displays the value
            Write("|" + p[i]);
        }
        WriteLine("|");

        //assigning the value of p to the last cell of pnt
        p = (byte*)pnt + m - 1;
        //creating a for loop that runs m-1 times
        for (int i = 0; i < m; i++)
        {
            //displays the value of the cell
            Write("|" + p[-i]);
        }
        WriteLine("|");

        /*creating a variable of type int and
        assigning its value to the divison of 8 and 2*/
        int n = sizeof(double) / sizeof(char);
        //creating a pointer of char type
        char* q;
        //assigning the value of q to the value of p converted to char pointer
        q = (char*)pnt;
        //creating a loop that runs n-1 times
        for (int i = 0; i < n; i++)
        {
            //assigns the value of the cell to the summation of 'A' and i
            q[i] = (char)('A' + i);
            //displays the value of the cell
            Write("|" + q[i]);
        }
        WriteLine("|");

        //assigns the value of q to the last cell of pnt
        q = (char*)pnt + n - 1;
        //creating a for loop that runs n - 1 times
        for (int i = 0; i < n; i++)
        {
            //displays the value of the cell
            Write("|" + q[-i]);
        }
        WriteLine("|");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}