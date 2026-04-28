namespace C_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數數字:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number % 2 == 0)
                Console.WriteLine("這是偶數:");
            else
                Console.WriteLine("這是奇數:");



        }
    }
}
