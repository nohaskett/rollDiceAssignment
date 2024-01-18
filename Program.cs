using rollDiceAssignment;

public class Program
{
    private static void Main(string[] args)
    {
        // Testing for Git 2.0

        // Call from the class
        rollFunction rf = new rollFunction();

        // Initialize a variable to collect the number of rolls from the user
        int num = 0;

        // Ask the user how many rolls
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many rolls do you want?");

        // Store the number of rolls to the variable
        num = int.Parse(System.Console.ReadLine());

        // Return the output from the method in our other class
        string returnedOutput = rf.PrintRolls(num);

        // Write it to the console
        System.Console.WriteLine(returnedOutput);

        System.Console.WriteLine("Thank you for playing the dice simulator! Goodbye!");
    }
}