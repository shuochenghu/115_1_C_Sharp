using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單與所有元件。
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MIN_SALARY = 40000m; // 最低年薪要求
            const int MIN_YEARS = 2; // 最低工作年資要求

            decimal salary;
            int yearsOnJob;

            try
            {
                salary = decimal.Parse(salaryTextBox.Text); // 取得年薪輸入
                yearsOnJob = int.Parse(yearsTextBox.Text); // 取得工作年資輸入

                // 判斷是否符合貸款資格
                if (salary < MIN_SALARY)
                {
                    decisionLabel.Text = "薪資不符合貸款資格。";
                }
                else
                {
                    if (yearsOnJob >= MIN_YEARS)
                    {
                        decisionLabel.Text = "符合貸款資格。";
                    }
                    else
                    {
                        decisionLabel.Text = "薪資符合但是年資不符合貸款資格。";
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除輸入欄位與結果顯示。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標移回第一個輸入欄位。
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前視窗。
            this.Close();
        }
    }
}
