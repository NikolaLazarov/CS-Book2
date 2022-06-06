using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        //creating a variable from class Random
        Random rnd = new Random();
        //creating a single d array variable
        int[] nums;
        //creating an int variable
        int x;
        //creating a loop that repeats 9 times
        for (int i = 0; i < 10; i++)
        {
            //displaying the var i
            Write("[{0}] ", i);
            //defining a try block
            try
            {
                //assigning the value of nums to a new array with length 2*rnd.Next(3)-1
                nums = new int[2 * rnd.Next(3) - 1];
                //assigning the value of x to 1/rnd.Next(3)
                x = 1 / rnd.Next(3);
                //assigning the element of index rnd.Next(2)-1 to x
                nums[rnd.Next(2) - 1] = x;
                //assigning the value of the first element to the string "Zero" converted to int32
                nums[0] = Int32.Parse("Zero");
            }
            //defining a catch block for an OverFlowException
            catch (OverflowException)
            {
                WriteLine("Error №1: Unequal size of array.");
            }
            //defining a catch block for a DivideByZeroException
            catch (DivideByZeroException)
            {
                WriteLine("Error №2: Division by zero.");
            }
            //defining a catch block for a IndexOutOfRangeException
            catch (IndexOutOfRangeException)
            {
                WriteLine("Error №3: Unequal index of element.");
            }
            //defining a catch block for a FormatException
            catch (FormatException)
            {
                WriteLine("Error №4: Unequal format of number.");
            }
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}