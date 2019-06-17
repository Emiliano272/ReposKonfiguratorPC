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
    /// Logika interakcji dla klasy UCPcCase10.xaml
    /// </summary>
    public partial class UCPcCase10 : System.Windows.Controls.UserControl
    {

        public UCPcCase10()
        {
            InitializeComponent();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DESKTOP-V2N6TGB;Initial Catalog=AppComponentsDB;Integrated Security=True;";

            try
            {
                sqlCon.Open();

                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = sqlCon;
                sqlComm.CommandText = "SELECT nazwa_produktu AS NazwaProduktu , cena AS Cena FROM ProduktyPC WHERE produktPC_id = 7 OR produktPC_id = 13 OR produktPC_id = 23 OR produktPC_id = 31 OR produktPC_id = 37 OR produktPC_id = 41 OR produktPC_id = 44 OR produktPC_id = 49 ";

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
