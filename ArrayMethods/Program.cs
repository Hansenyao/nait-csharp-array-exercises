namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_NUMBERS = 25;
            int[] InputNumbers = new int[MAX_NUMBERS];

            // Get user inputed numbers and count
            int InputCount = GetUserNumbers(InputNumbers);

            // Calc the mean average value
            int Average = MeanAverageOfNumbers(InputNumbers, InputCount);
            Console.WriteLine("Average: {0}", Average);

            // Get the largest number
            int LargestIndex = LargestNumber(InputNumbers, InputCount);
            Console.WriteLine("Largest: {0}", InputNumbers[LargestIndex]);

            // Get the smallest number
            int SmallestIndex = SmallestNumber(InputNumbers, InputCount);
            Console.WriteLine("Smallest: {0}", InputNumbers[SmallestIndex]);

            // Get the mode of numbers
            int ModeValue = Mode(InputNumbers, InputCount);
            Console.WriteLine("Mode: {0}", ModeValue);
        }

        /*
         * Get user inputing numbers, and save them into array Numbers
         * The max count of user inputing numbers is 25.
         * 
         * return the actual count of numbers.
         */
        static int GetUserNumbers(int[] Numbers)
        {
            Console.Write("Please enter the count of numbers (<=25): ");
            int Count = int.Parse(Console.ReadLine() ?? "0");
            if (Count <= 0 || Count > 25)
            {
                Console.WriteLine("The count of number must be bewteen 1 and 25.");
                return 0;
            }

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Please enter the number {0} of {1}: ", i + 1, Count);
                Numbers[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            return Count;
        }

        /*
         * Calculate the mean average value of numbers in Numbers.
         * 
         * Return the mean average value as integer
         * 
         */
        static int MeanAverageOfNumbers(int[] Numbers, int Count)
        {
            int Sum = 0;
            for (int i = 0; i < Count;i++)
            {
                Sum += Numbers[i];
            }
            return Sum / Count;
        }

        /*
         * Return the index of the largest number in array Numbers
         */
        static int LargestNumber(int[] Numbers, int Count)
        {
            int Index = 0;
            int MaxNumber = -999999999;
            for(int i = 0; i < Count;i++)
            {
                if (Numbers[i] > MaxNumber)
                {
                    MaxNumber = Numbers[i];
                    Index = i;
                }
            }
            return Index;
        }

        /*
         * Return the index of the smallest number in array Numbers
         */
        static int SmallestNumber(int[] Numbers, int Count)
        {
            int Index = 0;
            int MinNumber = 999999999;
            for (int i = 0; i < Count; i++)
            {
                if (Numbers[i] < MinNumber)
                {
                    MinNumber = Numbers[i];
                    Index = i;
                }
            }
            return Index;
        }

        /*
         * Return the mode of the numbers.
         * The mode is the number in a data set that occurs most frequently.
         * (if there is more than one, only one needs to be shown).
         * 
         */
        static int Mode(int[] Numbers, int Count)
        {
            int MaxTimes = 0;
            int ModeValue = 0;
            for (int i = 0; i < Count; i++)
            {
                int Times = 0;
                for (int j = 0; j < Count; j++)
                {
                    if (Numbers[i] == Numbers[j]) 
                    {
                        Times++;
                    }
                }
                if (Times > MaxTimes)
                {
                    MaxTimes = Times;
                    ModeValue = Numbers[i];
                }
            }
            return ModeValue;
        }
    }
}
