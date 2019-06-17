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
    /// Logika interakcji dla klasy UserControlPCParts.xaml
    /// </summary>
    public partial class UserControlPCParts : System.Windows.Controls.UserControl
    {
        public UserControlPCParts()
        {
            InitializeComponent();
        }

     
        
        private void ButtonSearchPC(object sender, RoutedEventArgs e)
        {
            int indexBudgetPC = ComboBoxBudgetPC.SelectedIndex;        

            switch (indexBudgetPC)
            {
                case 0:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase0());
                    break;
                case 1:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase1());
                    break;
                case 2:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase2());
                    break;
                case 3:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase3());
                    break;
                case 4:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase4());
                    break;
                case 5:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase5());
                    break;
                case 6:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase6());
                    break;
                case 7:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase7());
                    break;
                case 8:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase8());
                    break;
                case 9:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase9());
                    break;
                case 10:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase10());
                    break;
                case 11:
                    GridPCParts.Children.Clear();
                    GridPCParts.Children.Add(new UCPcCase11());
                    break;

                default:
                    break;



            }


        }
    }
}
