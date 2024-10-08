using System.Windows;

namespace YourNamespace
{
    public partial class PasswordCheckerWindow : Window
    {
        private string correctPassword = "secret123";

        public PasswordCheckerWindow()
        {
            InitializeComponent();
        }

        private void CheckPassword(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text == correctPassword)
            {
                ResultTextBlock.Text = "Секретное сообщение: Доступ разрешен!";
            }
            else
            {
                ResultTextBlock.Text = "Неверный пароль. Попробуйте ещё раз.";
            }
        }
    }
}

