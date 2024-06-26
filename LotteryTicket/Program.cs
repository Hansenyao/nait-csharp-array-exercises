/*
 *  A array programming exercise - Lottery Ticket
 *  
 *  Student: Hansen Yao
 * 
 *  Date: June 26, 2024
 */
namespace LotteryTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input values rang
            Console.Write("Please enter the range (from 10 to 50): ");
            int Range = int.Parse(Console.ReadLine() ?? "0");
            if (Range < 10 || Range > 50)
            {
                Console.WriteLine("Range must be bewteen 10 to 50.");
                return;
            }

            // Input the number of values in a pick
            Console.Write("Please enter the number of values: ");
            int Numbers = int.Parse(Console.ReadLine() ?? "0");
            if (Numbers < 1 || Numbers >= Range)
            {
                Console.WriteLine("The number of values must be bewteen 1 to Range.");
                return;
            }

            // Input the number of lottery tickets
            Console.Write("Please enter the number of tickets (<=5): ");
            int NumberOfTicket = int.Parse(Console.ReadLine() ?? "0");
            if (NumberOfTicket < 1 || NumberOfTicket > 5)
            {
                Console.WriteLine("The number of tickets must be bewteen 1 to 5.");
                return;
            }

            // Generate tickets and print the values in it
            Console.WriteLine("\nTottery tickets result:");
            for (int i = 0; i < NumberOfTicket; i++)
            {
                int[] Picks = new int[Numbers];
                QuickPick(Picks, Range);

                Console.Write("Ticket {0}: ", i + 1);
                for (int Index = 0; Index < Picks.Length; Index++)
                {
                    Console.Write(Picks[Index] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nEnd!\n");
        }

        static void QuickPick(int[] pick, int range)
        {
            if (pick.Length >= range) {
                Console.WriteLine("The pick's values number must be less than the range!");
                return;
            }

            for (int i = 0; i < pick.Length; i++)
            {
                int Value = 0;
                bool IsExist = false;
                do
                {
                    // Generate a new random value
                    Value = new Random().Next(1, range);

                    // Check the new value is picked or not
                    IsExist = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (pick[j] == Value)
                        {
                            IsExist = true;
                            break;
                        }
                    }
                } while (IsExist);

                // Get a valid value
                pick[i] = Value;
            }
        }
    }
}
