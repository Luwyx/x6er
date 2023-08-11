namespace x6er
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input amount of dice");
            int NumberOfDice = Convert.ToInt32(Console.ReadLine());



            Random random = new Random();

            int[] diceRolls = new int[NumberOfDice];

            int rollCount = 0;


            do
            {
                for (int i = 0; i < NumberOfDice; i++)
                {
                    diceRolls[i] = random.Next(1, 7);
                }

                rollCount++;

                Console.Write("Roll " + rollCount + ": ");
                foreach (int roll in diceRolls)
                {
                    Console.Write(roll + " ");
                }
                Console.WriteLine();
            }
            while (!Roll6(diceRolls));

            Console.WriteLine("It took " + rollCount + " to roll 6 on all dice");
            // Console.WriteLine("You rolled a " + diceRoll1);

        }


        static bool Roll6(int[] diceRolls)
        {
            foreach (int roll in  diceRolls) 
            {
                if (roll != 6)
                {
                    return false;
                }


            }
            return true;


        }

    }
        


    //public class dice
    //{
    //    public int NumberOfDice;
    //}
}