using static System.Console;
//creating a template struct
struct my_struct<X, Y>
{
    //creating 2 public fields
    public X first;
    public Y second;
    //creating a constructor which assigns the values of the fields
    public my_struct(X a, Y b)
    {
        first = a;
        second = b;
    }
    //creating a method that displays the fields of the struct
    public void show()
    {
        WriteLine("First field: {0}", first);
        WriteLine("Second field: {0}", second);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating a my_struct variables
        my_struct<string, int> A;
        //assigning the values of the fields
        A.first = "My Struct";
        A.second = 100;
        //using the method show of A
        A.show();

        //creating a my_struct object
        my_struct<char, int> B = new my_struct<char, int>('B', 200);
        //using the method show of B
        B.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}