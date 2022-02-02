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

namespace Задание_Wpf4
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
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(eRate.Text);
            double sumEuro = Convert.ToDouble(eSum.Text);
            double resEuro = rateEuro * sumEuro;
            eRes.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateFunt = Convert.ToDouble(fRate.Text);
            double sumFunt = Convert.ToDouble(fSum.Text);
            double resFunt = rateFunt * sumFunt;
            fResSum.Text = resFunt.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateJena = Convert.ToDouble(jRate.Text);
            double sumJena = Convert.ToDouble(jSum.Text);
            double resJena = rateJena * sumJena;
            jResSum.Text = resJena.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double inchesNumber = Convert.ToDouble(inches.Text);
            double resultForInches = inchesNumber * 0.0254;
            metersByInches.Text = resultForInches.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double ftNumber = Convert.ToDouble(ft.Text);
            double resultForFt = ftNumber * 0.3048;
            metersByFt.Text = resultForFt.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double milesNumber = Convert.ToDouble(miles.Text);
            double resultForMiles = milesNumber * 1609.344;
            metersByMiles.Text = resultForMiles.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double verstNumber = Convert.ToDouble(versts.Text);
            double resultForVersts = verstNumber * 1066.8;
            metersByVersts.Text = resultForVersts.ToString();
        }
    }
}
