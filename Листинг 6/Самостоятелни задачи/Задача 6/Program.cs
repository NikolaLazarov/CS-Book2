using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        int[] arr_Nums = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < arr_Nums.Length; i++)
        {
            arr_Nums[i] = rnd.Next(10);
            Write("|" + arr_Nums[i]);
        }
        WriteLine("|");
        Thread highest_value_ofarray = new Thread(() =>
        {
            int current_element = arr_Nums[0];
            for (int i = 0; i < arr_Nums.Length - 1; i++)
            {
                Thread.Sleep(500);
                WriteLine("Checking element: " + arr_Nums[i]);
                if (current_element < arr_Nums[i + 1])
                {
                    current_element = arr_Nums[i + 1];
                }
            }
            WriteLine("The highest element of the array is: " + current_element);
        });
        Thread lowest_value_ofarray = new Thread(() =>
        {
            int current_element = arr_Nums[0];
            for (int i = 0; i < arr_Nums.Length - 1; i++)
            {
                Thread.Sleep(500);
                WriteLine("Checking element: " + arr_Nums[i]);
                if (current_element > arr_Nums[i + 1])
                {

                    current_element = arr_Nums[i + 1];
                }
            }
            WriteLine("The lowest element of the array is: " + current_element);
        });
        highest_value_ofarray.Start();
        if (highest_value_ofarray.IsAlive) highest_value_ofarray.Join();
        lowest_value_ofarray.Start();
        if (lowest_value_ofarray.IsAlive) lowest_value_ofarray.Join();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}