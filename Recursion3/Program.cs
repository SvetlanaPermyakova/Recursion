namespace Recursion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            string? number1 = Console.ReadLine();
            Console.WriteLine("Введите второе число: ");
            string? number2 = Console.ReadLine();
            uint num1 = 0;
            uint num2 = 0;

            if (number1 != null)
            {
                num1 = uint.Parse(number1);
            }

            if (number2 != null)
            {
                num2 = uint.Parse(number2);
            }

            uint a = Recursion(num1, num2);
            Console.WriteLine(a);
        }

        public static uint Recursion(uint number1, uint number2)
        {
            if (number1 == 0)
            {
                return number2 + 1;
            }                
            else if ((number1 > 0) && (number2 == 0))
            {
                return Recursion(number1 - 1, 1);
            }                
            else
            {
                return Recursion(number1 - 1, Recursion(number1, number2 - 1));
            }                
        }
    }
}