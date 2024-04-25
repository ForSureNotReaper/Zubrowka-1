using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Styczen2203 styczen_2023 = new Styczen2203();
            styczen_2023.Show();

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            styczen2024 styczen_2024 = new styczen2024();
            styczen_2024.Show();

            this.Close();
        }
    }
}
