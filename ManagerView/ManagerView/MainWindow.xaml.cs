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

namespace ManagerView
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
        //Теперь игра запускается кликом по другой кнопке

        /*private void Start_Click(object sender, RoutedEventArgs e)
        {
          
        }*/

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Starts_Click(object sender, RoutedEventArgs e)
        {
            RegistartionWindow window = new RegistartionWindow();
            window.Show();
            Close();
        }
        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            RulesWindow window = new RulesWindow();
            window.Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
    }
}
