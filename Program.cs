namespace MyStudyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberList = { 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            string numberString;
            int low = 0;
            int high = numberList.Length - 1;
            int thisNumber = 0;
            int guess = 0;


            Console.WriteLine($"Guess : {thisNumber}, Find : {numberList[guess]}, Length: {high}");

            while (thisNumber < 15 || thisNumber > 30)
            try
            {
                    Console.WriteLine("Введите число от 15 до 30 :");
                    numberString = Console.ReadLine();
                    thisNumber = Convert.ToInt32(numberString);

            }
            catch
            {
                continue;
            }


            while (numberList[guess] != thisNumber)
            {
                guess = (low + high)/2;
                if (thisNumber < numberList[guess])
                {
                    high = guess - 1;
                }

                else if (thisNumber > numberList[guess])
                {
                    low = guess + 1;
                }


            }

            Console.WriteLine($"Guess : {thisNumber}, Find : {numberList[guess]}, Length: {high}");

        }
    }
}