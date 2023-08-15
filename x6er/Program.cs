namespace x6er
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input the number of dice
            Console.WriteLine("Input amount of dice");
            int NumberOfDice = Convert.ToInt32(Console.ReadLine());

            // Create a random number generator
            Random random = new Random();

            // Create an array to store dice rolls
            int[] diceRolls = new int[NumberOfDice];

            // Initialize a counter for the number of rolls
            int rollCount = 0;

            // Use a do-while loop to roll the dice until all show 6
            do
            {
                // Roll each die and store the result in the array
                for (int i = 0; i < NumberOfDice; i++)
                {
                    diceRolls[i] = random.Next(1, 7);
                }

                // Increment the roll count
                rollCount++;

                // Display the current roll count and the dice rolls
                Console.Write("Roll " + rollCount + ": ");
                foreach (int roll in diceRolls)
                {
                    Console.Write(roll + " ");
                }
                Console.WriteLine();
            }
            while (!Roll6(diceRolls)); // Continue rolling until all dice show 6

            // Display the total number of rolls needed to get all dice to 6
            Console.WriteLine("It took " + rollCount + " rolls to roll 6 on all dice");
        }

        // Function to check if all dice show 6
        static bool Roll6(int[] diceRolls)
        {
            foreach (int roll in diceRolls)
            {
                if (roll != 6)
                {
                    return false; // If any die doesn't show 6, return false
                }
            }
            return true; // If all dice show 6, return true
        }
    }
}
