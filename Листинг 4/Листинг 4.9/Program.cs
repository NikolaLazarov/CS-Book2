using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        //creating 3 variables and assigning their values
        int x = 100, y = 200, z = 300;
        //creating a int pointer array of 3 elements
        int*[] nums = new int*[3];

        //assigning the variables to the elements of the array
        nums[0] = &x;
        nums[1] = &y;
        nums[2] = &z;
        //displaying the contents
        WriteLine("Numbers: {0}, {1}, {2}", nums[0][0], *nums[1], nums[2][0]);

        //creating a char pointer array of 3 elements
        char*[] symbs = new char*[3];
        //assigning the variables value converted to char pointer ti the elements of array
        symbs[0] = (char*)&x;
        symbs[1] = (char*)&y;
        symbs[2] = (char*)&z;
        //creating a char variable and assigning its value
        char s = 'A';
        //creating 2 loops that assign and display the value of elements of the array
        for (int i = 0; i < symbs.Length; i++)
        {
            for (int j = 0; j < sizeof(int) / sizeof(char); j++)
            {
                symbs[i][j] = s;
                s++;
                Write(symbs[i][j] + " ");
            }
            WriteLine();
        }

        //displaying values of the variables
        WriteLine("Numbers: {0}, {1}, {2}", x, y, z);
        //displaying the addresses of the variables
        WriteLine("Checks: {0}, {1}, {2}", nums[0][0], *nums[1], nums[2][0]);
        //displaying the addresses of the symbs array converted to int type pointer
        WriteLine("Once more: {0}, {1}, {2}", *(int*)symbs[0], *(int*)symbs[1], *(int*)symbs[2]);
        //displaying the contents of the symbs array
        WriteLine("Checks: {0}, {1}, {2}", *symbs[0], *symbs[1], *symbs[2]);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}