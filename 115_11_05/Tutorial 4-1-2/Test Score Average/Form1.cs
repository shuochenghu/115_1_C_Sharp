using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    /// <summary>
    /// 成績平均計算表單。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化表單元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按下「計算平均」按鈕時執行。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 高分門檻常數（目前保留供後續邏輯使用）。
            // const double HIGH_SCORE = 95.0;

            const double PASSING_SCORE = 60.0; // 及格分數常數。

            // 宣告三次測驗成績與平均分數變數。
            double test1, test2, test3, average;
            string grade;

            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算平均分數。
                average = (test1 + test2 + test3) / 3.0;

                // 顯示平均分數，格式化為小數點後一位。
                averageLabel.Text = average.ToString("F1");

                if (average >= 60)  // 平均分數大於等於 60
                {
                    if (average >= 80)
                    {
                        // 平均分數大於等於 80
                        if (average >= 90)
                        {
                            // 平均分數大於等於 90
                            grade = "A";
                        }
                        else
                        {
                            // 平均分數介於 80（含）與 90（不含）之間
                            grade = "B";
                        }
                    }
                    else
                    {
                        // 平均分數介於 60（含）與 80（不含）之間
                        if (average >= 70)
                        {
                            // 平均分數介於 70（含）與 80（不含）之間
                            grade = "C";
                        }
                        else
                        {
                            // 平均分數介於 60（含）與 70（不含）之間
                            grade = "D";
                        }
                    }
                }
                else // 平均分數小於 60
                {
                    grade = "F";
                }

                // 顯示成績等級。
                //MessageBox.Show($"成績等級: {grade}");
                MessageBox.Show( "成績等級:" + grade);
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。
                // MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 按下「清除」按鈕時執行。
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空三個輸入欄位與平均分數顯示。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 將輸入焦點移回第一個成績欄位。
            test1TextBox.Focus();
        }

        /// <summary>
        /// 按下「離開」按鈕時執行。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單。
            this.Close();
        }
    }
}
