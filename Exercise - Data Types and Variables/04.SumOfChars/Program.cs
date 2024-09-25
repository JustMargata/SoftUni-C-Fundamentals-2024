namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                int number = char.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
