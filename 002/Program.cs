namespace _002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串:");
            string input = Console.ReadLine();
            string[] sArray = input.Split(',');

            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();

            foreach (string item in sArray)
            {
                int num = int.Parse(item);

                if(num % 2 == 0)
                {
                    evenList.Add(num);
                }
                else
                {
                    oddList.Add(num);
                }

                oddList.Sort();
                evenList.Sort();

               
                Console.WriteLine("奇數: " + string.Join(",", oddList));
                Console.WriteLine("偶數: " + string.Join(",", evenList));
            }






        }
    }
}
