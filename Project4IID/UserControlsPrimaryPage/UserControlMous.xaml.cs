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
    /// Logika interakcji dla klasy UserControlMous.xaml
    /// </summary>
    public partial class UserControlMous : System.Windows.Controls.UserControl
    {
        public UserControlMous()
        {
            InitializeComponent();
        }
        private void ButtonSearchMouse(object sender, RoutedEventArgs e)
        {
            int indexBudgetMouse = ComboBoxBrandMouse.SelectedIndex;

            switch (indexBudgetMouse)
            {
                case 0:
                    GridMouse.Children.Clear();
                    GridMouse.Children.Add(new UCMouseCase0());
                    break;
                case 1:
                    GridMouse.Children.Clear();
                    GridMouse.Children.Add(new UCMouseCase1());
                    break;
                case 2:
                    GridMouse.Children.Clear();
                    GridMouse.Children.Add(new UCMouseCase2());
                    break;
                case 3:
                    GridMouse.Children.Clear();
                    GridMouse.Children.Add(new UCMouseCase3());
                    break;
                case 4:
                    GridMouse.Children.Clear();
                    GridMouse.Children.Add(new UCMouseCase4());
                    break;
                case 5:
                    GridMouse.Children.Clear();
                    GridMouse.Children.Add(new UCMouseCase5());
                    break;

                default:
                    break;


            }
        }
    }
}
