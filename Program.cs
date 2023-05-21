using System;

namespace MyStudyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberList = new int[101];
            for (int i = 0; i < numberList.Length; i++)
            {
                numberList[i] = i;
            }

            string numberString;
            int low = 0;
            int high = numberList.Length - 1;
            int thisNumber = 0;
            int guess = 0;
            int iterationCount = 0;

            Console.WriteLine($"Guess : {thisNumber}, Find : {numberList[guess]}, Length: {high}");

            while (thisNumber < 1 || thisNumber > 100)
            {
                try
                {
                    Console.WriteLine("Введите число от 1 до 100:");
                    numberString = Console.ReadLine();
                    thisNumber = Convert.ToInt32(numberString);
                }
                catch
                {
                    continue;
                }
            }

            while (numberList[guess] != thisNumber)
            {
                guess = (low + high) / 2;
                iterationCount++;

                if (thisNumber < numberList[guess])
                {
                    high = guess - 1;
                }
                else if (thisNumber > numberList[guess])
                {
                    low = guess + 1;
                }


                Console.WriteLine($"Guess : {thisNumber}, Find : {numberList[guess]}, Count : {iterationCount}, Range: {numberList[low]} - {numberList[high]} ");
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Guess : {thisNumber}, Find : {numberList[guess]}, Length: {high}, Count : {iterationCount}");
            Console.ReadLine();
        }
    }
}
