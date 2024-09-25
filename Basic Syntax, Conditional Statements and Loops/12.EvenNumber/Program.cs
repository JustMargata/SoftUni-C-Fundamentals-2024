namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    if (num < 0)
                    {
                        num *= -1;
                    }
                    Console.WriteLine($"The number is: {num}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
