using System.Windows;

namespace YourNamespace
{
    public partial class RangeCheckerWindow : Window
    {
        public RangeCheckerWindow()
        {
            InitializeComponent();
        }

        private void CheckRange(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(NumberTextBox.Text, out double number))
            {
                if (number >= 0 && number <= 14)
                    ResultTextBlock.Text = "Число в промежутке [0 - 14]";
                else if (number >= 15 && number <= 35)
                    ResultTextBlock.Text = "Число в промежутке [15 - 35]";
                else if (number >= 36 && number <= 50)
                    ResultTextBlock.Text = "Число в промежутке [36 - 50]";
                else if (number > 50 && number <= 100)
                    ResultTextBlock.Text = "Число в промежутке [51 - 100]";
                else
                    ResultTextBlock.Text = "Число вне промежутков.";
            }
            else
            {
                ResultTextBlock.Text = "Некорректное число.";
            }
        }
    }
}
