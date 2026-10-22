using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    /// <summary>
    /// 主畫面：提供商品售價計算功能。
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
        /// 計算按鈕事件：讀取輸入並計算售價。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;  // 原價
            decimal discountPercentage;  // 折扣百分比
            decimal salePrice;      // 售價

            originalPrice = decimal.Parse(originalPriceTextBox.Text);  // 讀取原價
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);  // 讀取折扣百分比
            salePrice = originalPrice * (1 - discountPercentage / 100);  // 計算售價

            salePriceLabel.Text = salePrice.ToString("C");  // 顯示售價
        }

        /// <summary>
        /// 離開按鈕事件：關閉目前視窗。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
