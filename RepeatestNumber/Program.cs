namespace RepeatestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 2;
            int[] numbers = new int[30];
            int repeatsCount = 1;
            int maxRepeatsCount = 1;
            int repeatestNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minNumber, maxNumber + 1);
                Console.Write($"{numbers[i]} ");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    repeatsCount++;
                }
                else
                {
                    repeatsCount = 1;
                }

                if (repeatsCount > maxRepeatsCount)
                {
                    maxRepeatsCount = repeatsCount;
                    repeatestNumber = numbers[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"число {repeatestNumber} повторилось {maxRepeatsCount} раз подряд, что является наибольшим числом повторений.");
            Console.ReadKey();
        }
    }
}
