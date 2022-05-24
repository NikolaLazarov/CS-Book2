using static System.Console;
unsafe class Program
{
    public static void Main(string[] args)
    {
        //creating a variable of type double
        double val;
        //creating a variable of type int and assigning its value
        int k = 1;
        //creating two pointers of type double
        double* start, end;
        //assigning val to the first pointers value
        start = &val;
        //assigning start + 1 to the seconds pointer value
        end = start + 1;

        //displaying values of variables
        WriteLine("Address of start\t{0}", (uint)start);
        WriteLine("Address of end\t\t{0}", (uint)end);
        WriteLine("The subtraction of addresses{0,6}", (uint)end - (uint)start);
        WriteLine("Subtraction of double pointers\t{0,2}", end - start);
        WriteLine("Subtraction of int pointers\t{0,2}", (int*)end - (int*)start);
        WriteLine("Subtraction of char pointers\t{0,2}", (char*)end - (char*)start);
        WriteLine("Subtraction of byte pointers\t{0,2}", (byte*)end - (byte*)start);

        /*creating 3 pointers of 3 diff types
        and assigning start converted to their type as value*/
        byte* p = (byte*)start;
        char* q = (char*)start;
        int* r = (int*)start;
        //displaying values of pointers and other shiz
        WriteLine("Type byte: ");
        WriteLine("Address\tValue");
        while (p < end)
        {
            *p = (byte)k;
            WriteLine("{0}\t{1}", (uint)p, *p);
            p++;
            k += 2;
        }

        WriteLine("Type char: ");
        WriteLine("Address\tValue");
        for (k = 0; q + k < end; k++)
        {
            *(q + k) = (char)('A' + 2 * k);
            WriteLine("{0}\t{1}", (uint)(q + k), *(q + k));
        }

        WriteLine("Type int:");
        WriteLine("Address\tValue");
        for (k = 0; &r[k] < end; k++)
        {
            r[k] = 5 * (k + 1);
            WriteLine("{0}\t{1}", (uint)&r[k], r[k]);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}