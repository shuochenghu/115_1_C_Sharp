using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    static class Program
    {
        /// <summary>
        /// 應用程式的進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows 視覺化樣式
            Application.EnableVisualStyles();
            // 設定文字呈現相容性
            Application.SetCompatibleTextRenderingDefault(false);
            // 啟動主表單
            Application.Run(new Form1());
        }
    }
}
