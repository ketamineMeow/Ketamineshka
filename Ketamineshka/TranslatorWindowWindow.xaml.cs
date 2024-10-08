using System.Collections.Generic;
using System.Windows;

namespace YourNamespace
{
    public partial class TranslatorWindow : Window
    {
        private Dictionary<string, string> translations = new Dictionary<string, string>()
        {
            { "солнце", "sun" },
            { "дождь", "rain" },
            { "снег", "snow" },
            { "ветер", "wind" },
            { "облако", "cloud" },
            { "гром", "thunder" },
            { "молния", "lightning" },
            { "туман", "fog" },
            { "небо", "sky" },
            { "шторм", "storm" }
        };

        public TranslatorWindow()
        {
            InitializeComponent();
        }

        private void Translate(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text.Trim().ToLower();
            if (translations.TryGetValue(input, out string translation))
            {
                ResultTextBlock.Text = $"Перевод: {translation}";
            }
            else
            {
                ResultTextBlock.Text = "Такого слова нет.";
            }
        }
    }
}

