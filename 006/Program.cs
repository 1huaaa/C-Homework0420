using System;
using System.Windows.Forms;

namespace _006
{
    internal static class Program
    {
        /// <summary>
        ///  應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 下面這幾行是 WinForms 啟動的標準配備
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 這行最重要：告訴電腦「啟動時請打開 Form1」
            Application.Run(new Form1());
        }
    }
}