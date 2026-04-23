using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace _006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int year))

            {
               // int year = rocYear + 1911;

                DateTime startDate = new DateTime(year, 1, 1);
                DateTime endDate = new DateTime(year, 12, 31);
                int satCount = 0;
                int sunCount = 0;

                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        satCount++;
                    }
                    else if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        sunCount++;
                    }
                }

                label1.Text = "星期六 " + satCount + " 天";
                label2.Text = "星期日 " + sunCount + " 天";
            }

            /*
         private void btnCalculate_Click(object sender, EventArgs e)
         {
            if (int.TryParse(textBox1.Text, out int year))

             {
                 //取得該年的 1/1 是星期幾，以及該年總天數
                DateTime firstDay = new DateTime(year, 1, 1);
                int totalDays = DateTime.IsLeapYear(year) ? 366 : 365;
        
                 //基本天數：每週一定有一個週六、一個週日
                int weeks = totalDays / 7;
                int satCount = weeks;
                int sunCount = weeks;

                //處理剩餘的天數 (totalDays % 7)
                int remainingDays = totalDays % 7;
        
                for (int i = 0; i < remainingDays; i++)
                {
                    DayOfWeek day = firstDay.AddDays(i).DayOfWeek;
                    if (day == DayOfWeek.Saturday) satCount++;
                    if (day == DayOfWeek.Sunday) sunCount++;
                }

                    label1.Text = "星期六 " + satCount + " 天";
                    label2.Text = "星期日 " + sunCount + " 天";

            */


        }
    }
}