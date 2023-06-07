using System.Windows;

namespace WpfLab4_1
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

        private void butClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your name is " + txtFirstName.Text + " " + txtLastName.Text + " and your email address is " + txtEmail.Text);
        }
    }
}
