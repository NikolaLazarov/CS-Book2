using static System.Console;
//creating two enumerations
enum Animals { Cat, Dog, Fox, Wolf, Bear };
enum Coins { One = 1, Two, Five = 5, Ten = 10, Fifty = 50 };
public class Program
{
    public static void Main(string[] args)
    {
        WriteLine("In the world of animals");
        //creating two enumer variable
        Animals animal = Animals.Cat;

        //displaying the animal variable and its number value
        WriteLine("animal: {0,-5} or {1}", animal, (int)animal);

        //assigning the value of the enumer variable
        animal = Animals.Dog;
        //displaying the animal variable and its number value
        WriteLine("animal: {0,-5} or {1}", animal, (int)animal);

        //assigning the value of the enumer variable
        animal = (Animals)2;
        //displaying the animal variable and its number value
        WriteLine("animal: {0,-5} or {1}", animal, (int)animal);

        //assigning the value of the enumer variable
        animal = animal + 1;
        //displaying the animal variable and its number value
        WriteLine("animal: {0,-5} or {1}", animal, (int)animal);

        //assigning the value of the enumer variable
        animal++;
        //displaying the animal variable and its number value
        WriteLine("animal: {0,-5} or {1}", animal, (int)animal);

        WriteLine("In the world of finances");
        //creating an enumer variable
        Coins coin;
        //creating an Array class object and assigning it to Coins
        Array name = Enum.GetValues(typeof(Coins));
        //creating a loop that displays the contents of the enumer variable
        for (int i = 0; i < name.Length; i++)
        {
            coin = (Coins)name.GetValue(i);
            //displaying the Coin variable and its number value
            WriteLine("coin: {0,-5} or {1}", coin, (int)coin);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}