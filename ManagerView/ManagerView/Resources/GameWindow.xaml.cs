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
using System.Windows.Shapes;
using Model;

namespace ManagerView
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
            
        }
        int step = 1;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random Go = new Random();
            Cube.Text = Go.Next(0, 7).ToString();
           
           
             
            if (step % 2 == 1)

            {
                // MoveFishkaToStep(Go.Next(0,7));
                //выполняется функция хода для игрока т.к. игрок ходит первым и его ходы нечетные
            }

            else
            {// функция для компа}
                step++;
            }
        }

        Player Computer = new Player { Name = "Компьютер ходит", Money = 20000 };
        public void ComputerStep()
        {

        }

        Player player = new Player { Name = "Ваш ход", Money = 20000 };

        public void PlayerStep()
        {
           
        }

        
        public void MoveFishkaToStep(int steps, Ellipse Fishka)
        {
           // Fishka.MoveFocus
        }
    }
}
