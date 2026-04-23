namespace _004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int count = 1;
            for(int i = number; i >= 1; i--)
            {
                for(int j = 1; j <= count; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
                count++;

            }

        }
    }
}
