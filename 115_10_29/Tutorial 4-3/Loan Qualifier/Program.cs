using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows 視覺化樣式。
            Application.EnableVisualStyles();
            // 使用預設的文字轉譯方式。
            Application.SetCompatibleTextRenderingDefault(false);
            // 啟動主表單。
            Application.Run(new Form1());
        }
    }
}
