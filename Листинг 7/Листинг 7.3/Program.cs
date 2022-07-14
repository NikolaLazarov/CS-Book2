using static System.Console;
class Program
{
    //creating a static template method that displays the array given as argument
    static void show<T>(T[] array){
        for(int i = 0; i < array.Length; i++){
            Write("|"+array[i]);
        }
        WriteLine("|");
    }
    //creating a static template method that creates a new array(length = parameter)
    static T[] create<T>(int n){
        T[] array = new T[n];
        return array;
    }
    //creating a static template method that fills the array(first argument) with the second parameter
    static void fill<T>(T[] a, T b){
        for(int i = 0; i < a.Length; i++){
            a[i] = b;
        }
    }
    //creating a static template method that displays a random element of the the array(first arguments)
    static T getRandom<T>(T[] a, Random rnd){
        return a[rnd.Next(a.Length)];
    }
    static void Main(string[] args)
    {
        //creating a random class object and 4 arrays
        Random rnd = new Random();
        string[] A = {
            "One",
            "Two",
            "Three"
        };
        int[] B = {2,3,5,13,21};
        char[] C = {'c','h','a','r','l','i'};
        //using the method show on A and B
        show(A);
        show(B);
        //using getRandom 10 times
        for(int i = 1; i <= 10; i++){
            Write(getRandom(B,rnd)+" ");
        }
        WriteLine();
        //using the method show on A and B
        show(C);
        //using getRandom 10 times
        for(int i = 1; i <= 10; i++){
            Write(getRandom(C,rnd)+" ");
        }
        WriteLine();
        //creating a new array via method create
        char[] symbs = create<char>(6);
        //using the method fill to fill the array
        fill(symbs,'W');
        //using the method show of symbs
        show(symbs);
        //creating a new array via method create
        int[] nums = create<int>(7);
        //using the method fill to fill the array
        fill(nums,3);
        //using the method show on nums
        show(nums);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}