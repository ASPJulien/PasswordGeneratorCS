using System.Windows.Controls;

namespace Password_generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public static int Security = 0;

        public static Window1 Adv = new Window1();
        
        public MainWindow()
        {
            InitializeComponent();
            Window1 Adv = new Window1();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Result.Text = Generator.Generate(false);
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

        private void AdvancedButton(object sender, System.Windows.RoutedEventArgs e)
        {
            Adv.Show();
        }

    }

}