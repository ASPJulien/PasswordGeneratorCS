using System.Windows.Controls;

namespace Password_generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public static int Security = 0;
        
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Result.Text = Generator.Generate();
        }

        private void RadioButton_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            Security = 0;
        }

        private void RadioButton_Checked_1(object sender, System.Windows.RoutedEventArgs e)
        {
            Security = 1;
        }

        private void RadioButton_Checked_2(object sender, System.Windows.RoutedEventArgs e)
        {
            Security = 2;
        }
    }
}