using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    /// <summary>
    /// 生日日期字串表單：將使用者輸入的星期、月份、日期與年份組合成日期字串顯示。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單上的所有元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「顯示日期」按鈕事件：組合輸入內容並顯示於結果標籤。
        /// </summary>
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 用來存放組合後的日期字串
            string output;

            // 依「星期, 月份 日期, 年份」的格式串接各文字方塊內容
            output = dayOfWeekTextBox.Text + ", " + monthTextBox.Text + " " + dayOfMonthTextBox.Text + ", " + yearTextBox.Text;

            // 將結果顯示在輸出標籤
            dateOutputLabel.Text = output;
        }

        /// <summary>
        /// 「清除」按鈕事件：清空所有輸入欄位與結果標籤。
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空四個輸入文字方塊
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";

            // 清空結果標籤
            dateOutputLabel.Text = "";
        }

        /// <summary>
        /// 「離開」按鈕事件：關閉表單並結束程式。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
