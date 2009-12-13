using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApplication1.PlayerInfoDataSet PlayerInfoDataSet = ((WpfApplication1.PlayerInfoDataSet)(this.FindResource("PlayerInfoDataSet")));
            // Load data into the table Total_Results. You can modify this code as needed.
            WpfApplication1.PlayerInfoDataSetTableAdapters.Total_ResultsTableAdapter playerInfoDataSetTotal_ResultsTableAdapter = new WpfApplication1.PlayerInfoDataSetTableAdapters.Total_ResultsTableAdapter();
            playerInfoDataSetTotal_ResultsTableAdapter.Fill(PlayerInfoDataSet.Total_Results);
            System.Windows.Data.CollectionViewSource total_ResultsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("total_ResultsViewSource")));
            total_ResultsViewSource.View.MoveCurrentToFirst();
        }

        private void total_ResultsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
