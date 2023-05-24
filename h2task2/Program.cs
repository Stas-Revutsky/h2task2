namespace h2task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int min = firstNumber;
            int max = firstNumber;

            if (secondNumber < min)
            {
                min = secondNumber;
            }
            else if (secondNumber > max)
            {
                max = secondNumber;
            }
            if (thirdNumber < min)
            {
                min = thirdNumber;
            }
            else if(thirdNumber > max)
            {
                max = thirdNumber;
            }

            Console.WriteLine($"The max is {max} and the min is {min}");
        }
    }
}