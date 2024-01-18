using rollDiceAssignment;

public class Program
{
    private static void Main(string[] args)
    {
        // Testing for Git
        rollFunction rf = new rollFunction();

        int num = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many rolls do you want?");

        num = int.Parse(System.Console.ReadLine());

        string returnedOutput = rf.PrintRolls(num);

        System.Console.WriteLine(returnedOutput);

        System.Console.WriteLine("Thank you for playing the dice simulator! Goodbye!");
    }
}