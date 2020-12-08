using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Password_generator
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public static int Length;
        public static bool IsAlphaNum;
        public static bool IsSpecial;

        public Window1()
        {
            InitializeComponent();
        }

        public void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Length = (int) SliderLength.Value;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            IsAlphaNum = false;
            IsSpecial = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Generator.Generate(true);
        }

        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            IsAlphaNum = true;
            IsSpecial = false;
        }

        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            IsAlphaNum = true;
            IsSpecial = true;
        }
    }
}
