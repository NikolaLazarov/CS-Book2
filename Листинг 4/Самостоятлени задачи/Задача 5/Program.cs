using static System.Console;
public class Program
{
    struct _struct
    {
        public int num;
        public char symb;
        public void show()
        {
            WriteLine("Number field: {0}\nCharacter filed: {1}", num, symb);
        }
    }
    unsafe static void Main(string[] args)
    {
        _struct A = new _struct();
        int* n = &A.num;
        char* s = &A.symb;
        *n = 123;
        *s = 'H';
        A.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}