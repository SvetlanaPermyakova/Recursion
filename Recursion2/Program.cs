namespace Recursion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            string? number1 = Console.ReadLine();
            Console.WriteLine("Введите второе число: ");
            string? number2 = Console.ReadLine();
            int num1 = 0;
            int num2 = 0;            

            if (number1 != null)
            {
                num1 = int.Parse(number1);
            }

            if (number2 != null)
            {                
                num2 = int.Parse(number2);
            }           

            int sum = Recursion(num1, num2);

            Console.WriteLine(sum);
        }

        public static int Recursion(int number1, int number2)
        { 
            int sum1 = 0;
            int sum2 = 0;
            sum1 += number1;            
            number1 += 1;

            if (number1 <= number2)
            {
               sum2 = Recursion(number1, number2);
            }

            return sum1 + sum2;
        }
    }
}