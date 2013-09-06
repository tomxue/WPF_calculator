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
using System.Text.RegularExpressions;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regex r = new Regex("^[0-9]{1,}$");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (r.IsMatch(textbox1.Text) && r.IsMatch(textbox2.Text))
                    textbox3.Text = Convert.ToString(Convert.ToInt32(textbox1.Text) + Convert.ToInt32(textbox2.Text));
                else
                    MessageBox.Show("Please input integer number!");
            }
            catch (Exception)
            {
                MessageBox.Show("Exception occurs!");
            }
            finally
            {
                MessageBox.Show("You come to finally handler!");
            }
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!r.IsMatch(textbox1.Text))
            {
                textbox1.Clear();
                MessageBox.Show("Please input integer number!");
            }
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!r.IsMatch(textbox2.Text))
            {
                textbox2.Clear();
                MessageBox.Show("Please input integer number!");
            }
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}