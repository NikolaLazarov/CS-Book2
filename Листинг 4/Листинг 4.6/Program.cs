using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        //creating a variable and assigning its value
        int size = 10;
        //creating a pointer of type int
        int* q;
        //creating an int array(its length defined by the var size)
        int[] nums = new int[size];
        WriteLine("Filling the contents of the array:");
        /*using a fixed function,
        creating a pointer of type int and assigning its value to num*/
        fixed (int* p = nums)
        {
            //assigning the value of q to the value of p + size - 1;
            q = p + size - 1;
            //creating a loop that fils the contents of the array and displays the one by one
            for (int i = 0; i < nums.Length; i++)
            {
                p[i] = i + 1;
                Write("|" + nums[i]);
            }
            WriteLine("|");
            //creating a while loop that multiplies the value of each of the contents of the array
            while (p <= q)
            {
                (*q) *= (*q);
                q--;
            }
            WriteLine("The array after changes are applied:");
            //displaying the contents of the array nums via a for loop
            for (int i = 0; i < nums.Length; i++)
            {
                Write("|" + nums[i]);
            }
            WriteLine("|");
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}