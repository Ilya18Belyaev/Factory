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

namespace Factory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int norma1 = int.Parse(Norma1TextBox.Text);
            int norma2 = int.Parse(Norma2TextBox.Text);
            int norma3 = int.Parse(Norma3TextBox.Text);

            int detali1 = int.Parse(Detali1TextBox.Text);
            int detali2 = int.Parse(Detali2TextBox.Text);
            int detali3 = int.Parse(Detali3TextBox.Text);

            int detali1PerMonth = detali1 * 8 * 30;
            int detali2PerMonth = detali2 * 8 * 30;
            int detali3PerMonth = detali3 * 8 * 30;


            double totalProfit = 0;

            if (detali1PerMonth >= norma1)
            {
                totalProfit += detali1PerMonth * 12.5;
            }

            if (detali2PerMonth >= norma2)
            {
                totalProfit += detali2PerMonth * 13.5;
            }

            if (detali3PerMonth >= norma3)
            {
                totalProfit += detali3PerMonth * 10;
            }

            if (detali1PerMonth >= norma1 && detali2PerMonth >= norma2 && detali3PerMonth >= norma3)
            {
                resultTextBlock.Content = $"Общая прибыль предприятия: {totalProfit} руб.";
            }
            else
            {
                double reducedProfit = totalProfit * 0.7;
                resultTextBlock.Content = $"Общая прибыль предприятия: {reducedProfit} руб. (с учетом штрафа)";
            }
        }
    }
}
