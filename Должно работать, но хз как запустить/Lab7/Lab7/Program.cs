
internal class Program
{
    private static void Main(string[] args)
    {

            Console.Write("Введите число от 1 до 26: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 & n <= 26)
            {
                for (char c = 'A'; c < 'A' + n; c++)
                    Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("Введите корректное число");
            }

    }
}
