using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km;  // 儲存行駛公里數。
            double liters; // 儲存使用汽油公升數。
            double kmpl; // 儲存每公升汽油行駛公里數。

            km = double.Parse(kmTextBox.Text); // 取得使用者輸入的行駛公里數。
            liters = double.Parse(literTextBox.Text); // 取得使用者輸入的使用汽油公升數。
            kmpl = km / liters; // 計算每公升汽油行駛公里數。

            kmplLabel.Text = kmpl.ToString("F2") + " 公里/公升";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
