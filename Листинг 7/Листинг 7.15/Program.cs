using static System.Console;
//creating a template delegate
//restriction: type can be non referancable
delegate T md<T>(T[] arg) where T: struct;
class Program
{
    //creating a template method
    //restriction: type can be non referancable
    //returns the first index's value of the array
    static T First<T>(T[] t) where T: struct{
       return t[0]; 
    }
    //creating a template method
    static T Last<T>(T[] t){
        //returns the last index's value of the array
        return t[t.Length-1];
    }
    //creating a method
    //returns the index with the highest value of the array
    static int MaxVal(int[] a){
        int val = a[0];
        for(int i = 1; i < a.Length; i++){
            if (val<a[i]) val = a[i];
        }
        return val;
    }
    static void Main(string[] args)
    {
        //creating 3 delegates
        md<int> A = First<int>;
        md<char> B = Last;
        md<int> C = MaxVal;
        //creating 3 varaible and assigning them to the value of the methods outcome
        int x = A(new int[]{10,7,3,1});
        char y = B(new char[]{'A','C','F'});
        int z = C(new int[]{1,7,2,5,11,9,3,6});
        //displaying the the variables
        WriteLine("Value: {0}, {1} and {2}",z,y,x); 
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}