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
    /// Logika interakcji dla klasy UserControlMonitors.xaml
    /// </summary>
    public partial class UserControlMonitors : System.Windows.Controls.UserControl
    {
        public UserControlMonitors()
        {
            InitializeComponent();
        }
        private void ButtonSearchMonitor(object sender, RoutedEventArgs e)
        {
            int indexBudgetMonitors = ComboBoxBudgetMonitors.SelectedIndex;

            switch (indexBudgetMonitors)
            {
                case 0:
                    GridMonitors.Children.Clear();
                    GridMonitors.Children.Add(new UCMonitorsCase0());
                    break;
                case 1:
                    GridMonitors.Children.Clear();
                    GridMonitors.Children.Add(new UCMonitorsCase1());
                    break;
                case 2:
                    GridMonitors.Children.Clear();
                    GridMonitors.Children.Add(new UCMonitorsCase2());
                    break;
                case 3:
                    GridMonitors.Children.Clear();
                    GridMonitors.Children.Add(new UCMonitorsCase3());
                    break;
                case 4:
                    GridMonitors.Children.Clear();
                    GridMonitors.Children.Add(new UCMonitorsCase4());
                    break;
                case 5:
                    GridMonitors.Children.Clear();
                    GridMonitors.Children.Add(new UCMonitorsCase5());
                    break;

                default:
                    break;


            }
        }
    }
}
