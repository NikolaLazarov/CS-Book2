using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        //creaitng a Random and int variables and an int array var
        Random rnd = new Random();
        int[] nums;
        int x, n;
        //creating a loop that repeats 9 times
        for (int i = 0; i < 10; i++)
        {
            //displaying the present time
            WriteLine("[{0}] ", i);
            //assigning the value of n to 1
            n = 1;
            //using a try function to check for errors
            try
            {
                //assigning the array with length 2*rnd.Next(3)-1
                nums = new int[2 * rnd.Next(3) - 1];
                //incrementing the value
                n++;
                //assigning x to 1/rnd.Next(3)
                x = 1 / rnd.Next(3);
                //incrementing the value
                n++;
                //assing the rnd.Next(2)-1 index to x
                nums[rnd.Next(2) - 1] = x;
                //incrementing the value
                n++;
                //assigning the first index of the array to zero converted to int32
                nums[0] = Int32.Parse("Zero");
            }
            //catch block in case of an exception
            catch (Exception e)
            {
                //the number of the command
                WriteLine("Command №{0}: ", n);
                //displaying the name of the exception
                WriteLine(e.GetType().Name);
                //displaying the message of the said exception
                WriteLine(" - " + e.Message);
            }
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}