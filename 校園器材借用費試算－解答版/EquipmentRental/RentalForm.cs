using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 每次試算先清除上一次的結果。
            dailyRateLabel.Text = "—";
            discountLabel.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                if (days >= 1 && days <= 7)
                {
                    // 依借用天數選出每日費用。
                    int dailyRate;
                    if (days <= 2)
                    {
                        dailyRate = 80;
                    }
                    else if (days <= 5)
                    {
                        dailyRate = 70;
                    }
                    else
                    {
                        dailyRate = 60;
                    }

                    // 先判斷是否為社團借用，再判斷是否達到折抵門檻。
                    int discount = 0;
                    string discountStatus;
                    if (clubCheckBox.Checked)
                    {
                        if (days >= 3)
                        {
                            discount = 30;
                            discountStatus = "折抵 30 元";
                        }
                        else
                        {
                            discountStatus = "未達折抵門檻";
                        }
                    }
                    else
                    {
                        discountStatus = "無優惠";
                    }

                    int total = days * dailyRate - discount;
                    dailyRateLabel.Text = dailyRate.ToString() + " 元";
                    discountLabel.Text = discountStatus;
                    totalLabel.Text = total.ToString() + " 元";
                }
                else
                {
                    feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                }
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            daysTextBox.Text = "";
            clubCheckBox.Checked = false;
            feedbackLabel.Text = "";
            dailyRateLabel.Text = "—";
            discountLabel.Text = "—";
            totalLabel.Text = "—";
        }
    }
}
