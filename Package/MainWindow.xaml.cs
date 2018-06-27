using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Package
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int a = 0;
        int b = 0;
        int a1 = 0;
        int a2 = 0;
        int b1 = 0;
        int b2 = 0;

        public float itemPriceValue
        {
            get
            {
                // 判斷是否為數字
                try
                {
                    return float.Parse(heavy.Text);
                }
                // 失敗後要求用家輸入數字
                catch
                {
                    MessageBox.Show("請輸入數字");
                    return 0;
                }
            }
            set
            {
                heavy.Text = value.ToString();
            }
        }

        private void Home1_Click(object sender, RoutedEventArgs e) // 本島寄出
        {

            if(itemPriceValue <5 )
            {
                a=70;
            }
            else if(itemPriceValue >=5 && itemPriceValue< 10)
            {
                a = 90;
            }
            else if (itemPriceValue >=10 && itemPriceValue < 15)
            {
                a = 110;
            }
            else if (itemPriceValue >= 15 && itemPriceValue <=20)
            {
                a = 135;
            }
            else
            {
                a = 0;
            }
        }

        private void Home2_Click(object sender, RoutedEventArgs e) // 外島寄出
        {

            if (itemPriceValue < 5)
            {
                b = 70;
            }
            else if (itemPriceValue >= 5 && itemPriceValue < 10)
            {
                b = 90;
            }
            else if (itemPriceValue >= 10 && itemPriceValue < 15)
            {
                b = 110;
            }
            else if (itemPriceValue >= 15 && itemPriceValue <= 20)
            {
                b = 135;
            }
            else
            {
                b = 0;
            }
        }

        private void landin1_Click(object sender, RoutedEventArgs e) // 本島同區
        {
            if(a > 0)
            {
                a1 = a;
            }

            // 外島跨本島
            else if(b == 70)
            {
                a1 = 100;
            }
            else if (b == 90)
            {
                a1 = 125;
            }
            else if (b == 110)
            {
                a1 = 150;
            }
            else if (b == 135)
            {
                a1 = 180;
            }
            else
            {
                a1 = 0;
            }
        }

        private void landin2_Click(object sender, RoutedEventArgs e) // 本島跨區
        {
            if (a > 0)
            {
                a2 = a + 10;
            }

            // 外島跨本島
            else if (b == 70)
            {
                a2 = 100;
            }
            else if (b == 90)
            {
                a2 = 125;
            }
            else if (b == 110)
            {
                a2 = 150;
            }
            else if (b == 135)
            {
                a2 = 180;
            }
            else
            {
                a2 = 0;
            }
        }

        private void landout1_Click(object sender, RoutedEventArgs e) // 外島同區
        {
            if (b > 0)
            {
                b1 = b;
            }

            // 本島跨外島
            else if (a == 70)
            {
                b1 = 100;
            }
            else if (a == 90)
            {
                b1 = 125;
            }
            else if (a == 110)
            {
                b1 = 150;
            }
            else if (a == 135)
            {
                b1 = 180;
            }
            else
            {
                b1 = 0;
            }
        }

        private void landout2_Click(object sender, RoutedEventArgs e) // 外島跨區
        {
            // 本島跨外島
            if (a == 70 )
            {
                b2 = 100;
            }
            else if (a == 90)
            {
                b2 = 125;
            }
            else if (a == 110)
            {
                b2 = 150;
            }
            else if (a == 135)
            {
                b2 = 180;
            }

            // 外島跨外島
            else if (b == 70)
            {
                b2 = 100;
            }
            else if (b == 90)
            {
                b2 = 125;
            }
            else if (b == 110)
            {
                b2 = 150;
            }
            else if (b == 135)
            {
                b2 = 180;
            }
            else
            {
                b1 = 0;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // 建立變數
            int Total = 0;

            // 按 enter 計算總支出
            if (e.Key == Key.Return)
            {
                Total = a1+a2+b1+b2;
            }
                // 顯示價格
                TotalPrice.Text = Total.ToString();
            }
        }
    }

