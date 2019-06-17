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
    /// Logika interakcji dla klasy UCMonitorsCase5.xaml
    /// </summary>
    public partial class UCMonitorsCase5 : System.Windows.Controls.UserControl
    {
        

        public UCMonitorsCase5()
        {
            InitializeComponent();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DESKTOP-V2N6TGB;Initial Catalog=AppComponentsDB;Integrated Security=True;";

            try
            {
                sqlCon.Open();

                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = sqlCon;
                sqlComm.CommandText = "SELECT nazwa_produktu AS NazwaProduktu , cena AS Cena FROM ProduktyPC WHERE produktPC_id = 60";

                DataTable data = new DataTable();
                data.Load(sqlComm.ExecuteReader());
                myDataGrid.ItemsSource = data.DefaultView;

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
