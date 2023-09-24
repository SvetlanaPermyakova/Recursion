namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string? number = Console.ReadLine();
            int num = 0;            

            if (number != null)
            {
                num = int.Parse(number);
            }

            Recursion(num);
        }

        public static void Recursion(int number)
        {
            Console.WriteLine(number);
            number -= 1;
            if (number >= 1)
            {
                Recursion(number);
            }            
        }
    }
}