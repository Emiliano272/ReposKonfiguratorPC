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
using System.Data;
using System.Data.SqlClient;

namespace Project4IID
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        // Przycisk do wyłączania MainWindow
        private void ButtonPowerOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        // Przycisk do minimalizowania MainWindow
        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
            else if(this.WindowState == WindowState.Minimized)
            {
                this.WindowState = WindowState.Normal;
            }
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Minimized;
            }
            else if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
        }

        // Przycisk do maksymalizowania MainWindow
        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
        }

        // Funkcja do możliwości poruszania okienkiem
        private void Grid_MouseDown(object sender, RoutedEventArgs e)
        {
            DragMove();
        }
        private void ListViewMenu_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int indeks = ListViewMenu.SelectedIndex;
            MoveCursorMenu(indeks);

            // instrukcja switch do zmieniania primary grida, wciskajac odpowiedni button
            switch (indeks)
            {
                case 0:
                    GridPrimary.Children.Clear();
                    GridPrimary.Children.Add(new UserControl1PrimaryPage());
                    break;
                case 1:
                    GridPrimary.Children.Clear();
                    GridPrimary.Children.Add(new UserControlPCParts());
                    break;
                case 2:
                    GridPrimary.Children.Clear();
                    GridPrimary.Children.Add(new UserControlMonitors());
                    break;
                case 3:
                    GridPrimary.Children.Clear();
                    GridPrimary.Children.Add(new UserControlMous());
                    break;
                case 4:
                    GridPrimary.Children.Clear();
                    GridPrimary.Children.Add(new UserControl1Keyboard());
                    break;
                default:
                    break;
            }
        }
        private void MoveCursorMenu(int indeks)
        {
            TrainsitioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * indeks)), 0, 0);
        }

       

        

        

    }
}
