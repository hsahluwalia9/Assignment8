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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new VM();
            DataContext = vm;
           
        }
        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            vm.Game();
            vm.CheckO();
            vm.CheckX();
            vm.CheckDraw();

            if (vm.CheckDraw() == true)
            {
                TbOutput.Text = ("Draw");
            }
            else if (vm.CheckO() == true)
            {
                TbOutput.Text = ("Player O wins");
            }
            else if (vm.CheckX() == true)
            {
                TbOutput.Text = ("Player X wins");
            }
        }
    }
}