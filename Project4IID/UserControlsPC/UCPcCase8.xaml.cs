﻿using System;
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
    /// Logika interakcji dla klasy UCPcCase8.xaml
    /// </summary>
    public partial class UCPcCase8 : System.Windows.Controls.UserControl
    {

        public UCPcCase8()
        {
            InitializeComponent();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DESKTOP-V2N6TGB;Initial Catalog=AppComponentsDB;Integrated Security=True;";

            try
            {
                sqlCon.Open();

                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = sqlCon;
                sqlComm.CommandText = "SELECT nazwa_produktu AS NazwaProduktu , cena AS Cena FROM ProduktyPC WHERE produktPC_id = 5 OR produktPC_id = 13 OR produktPC_id = 21 OR produktPC_id = 30 OR produktPC_id = 36 OR produktPC_id = 41 OR produktPC_id = 43 OR produktPC_id = 49 ";

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
