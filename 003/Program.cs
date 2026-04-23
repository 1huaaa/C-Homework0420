namespace _003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串:");
            string input = Console.ReadLine();
            string[] sArray = input.Split(',');

            for (int i = sArray.Length - 1; i >= 0; i--)
            {
                // 印出當前的元素
                Console.Write(sArray[i]);

                // 判斷是否要印逗號：只要不是最後一個 (索引 0)，就印逗號
                if (i > 0)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
