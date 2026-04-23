namespace _005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個中華民國年份:");
            string input = Console.ReadLine();
            int westernYear = int.Parse(input) + 1911;

            if (DateTime.IsLeapYear(westernYear))
            {
                Console.WriteLine($"民國 {input} 年是閏年");
            }
            else
            {
                Console.WriteLine($"民國 {input} 年是平年");
            }

            Console.ReadLine();
        }
    }
}
