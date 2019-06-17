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

namespace Project4IID
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl1Keyboard.xaml
    /// </summary>
    public partial class UserControl1Keyboard : System.Windows.Controls.UserControl
    {
        public UserControl1Keyboard()
        {
            InitializeComponent();
        }
        private void ButtonSearchKeyboard(object sender, RoutedEventArgs e)
        {
            int indexBudgetKeyboard = ComboBoxBudgetKeyboard.SelectedIndex;

            switch (indexBudgetKeyboard)
            {
                case 0:
                    GridKeyboard.Children.Clear();
                    GridKeyboard.Children.Add(new UCKeyboardCase0());
                    break;
                case 1:
                    GridKeyboard.Children.Clear();
                    GridKeyboard.Children.Add(new UCKeyboardCase1());
                    break;
                case 2:
                    GridKeyboard.Children.Clear();
                    GridKeyboard.Children.Add(new UCKeyboardCase2());
                    break;
                case 3:
                    GridKeyboard.Children.Clear();
                    GridKeyboard.Children.Add(new UCKeyboardCase3());
                    break;
                case 4:
                    GridKeyboard.Children.Clear();
                    GridKeyboard.Children.Add(new UCKeyboardCase4());
                    break;
                default:
                    break;

            }

        }
    }
}
