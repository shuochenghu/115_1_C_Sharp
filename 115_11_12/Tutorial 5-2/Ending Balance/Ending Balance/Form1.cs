using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單與所有介面元件。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal RATE = 0.005m; // 每個月的利率為 0.5%
            decimal balance;
            int months;


            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    int count = 1;
                    while (count <= months)
                    {
                        // 計算每個月的利息與新的餘額。
                         balance = balance * (1 + RATE); // 假設每個月的利率為 0.5%
                        // 將每個月的明細加入清單框。
                        detailListBox.Items.Add($"第 {count} 個月的本利和：{balance:C2}");
                        count = count + 1;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數量。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額。");               
            }
            endingBalanceLabel.Text = balance.ToString("C2");
        }
                        
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空輸入欄位、結果標籤與明細清單。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 將游標焦點移回起始餘額輸入框。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單。
            this.Close();
        }
    }
}
