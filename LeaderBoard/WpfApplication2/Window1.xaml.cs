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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 
    public partial class Window1 : Window
    {
        string[] Name = new string[8]{"Bill", "Joe", "Bob", "Gary", "Ron", "George", "Frank", "Harry"};
        int[,] Record = new int[8,3] {{2,4,2}, {4,3,1}, {4,4,0}, {2,5,1}, {6,0,0}, {2,6,1}, {4,3,0}, {4,3,1}};

        int[] Holding_Record = new int[3];
        string Holding_Name;

        public void _Sort_by_wins()
        {
            for (int q = 0; q < 7; q++)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (Record[i, 0] < Record[i + 1, 0])
                    {
                        for (int k = 0; k <= 2; k++)
                        {
                            Holding_Record[k] = Record[i, k];
                        }
                        Holding_Name = Name[i];
                        for (int k = 0; k <= 2; k++)
                        {
                            Record[i, k] = Record[i + 1, k];
                        }
                        Name[i] = Name[i + 1];
                        for (int k = 0; k <= 2; k++)
                        {
                            Record[i + 1, k] = Holding_Record[k];
                        }
                        Name[i + 1] = Holding_Name;
                    }
                }
            }            
        }

        public void _Sort_by_draws()
        {
            for (int q = 0; q < 7; q++)
            {
                for (int i = 0; i < 7; i++)
                {
                    if((Record[i,0] == Record[i+1,0]) && (Record[i, 2] < Record[i + 1, 2]))
                    {
                        for (int k = 0; k <= 2; k++)
                        {
                            Holding_Record[k] = Record[i, k];
                        }
                        Holding_Name = Name[i];
                        for (int k = 0; k <= 2; k++)
                        {
                            Record[i, k] = Record[i + 1, k];
                        }
                        Name[i] = Name[i + 1];
                        for (int k = 0; k <= 2; k++)
                        {
                            Record[i + 1, k] = Holding_Record[k];
                        }
                        Name[i + 1] = Holding_Name;
                    }
                }
            }
        }

        public void _Sort_by_losses()
        {
            for (int q = 0; q < 7; q++)
            {
                for (int i = 0; i < 7; i++)
                {
                    if ((Record[i,0] == Record[i+1,0]) && (Record[i,2] == Record[i+1,2]) && (Record[i, 1] > Record[i + 1, 1]))
                    {
                        for (int k = 0; k <= 2; k++)
                        {
                            Holding_Record[k] = Record[i, k];
                        }
                        Holding_Name = Name[i];
                        for (int k = 0; k <= 2; k++)
                        {
                            Record[i, k] = Record[i + 1, k];
                        }
                        Name[i] = Name[i + 1];
                        for (int k = 0; k <= 2; k++)
                        {
                            Record[i + 1, k] = Holding_Record[k];
                        }
                        Name[i + 1] = Holding_Name;
                    }
                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //foreach (string i in Name)
            //{
            //    Textbox1.Text = (i);
            //}
            //Textbox1.Text = Name[0]+ " " + Record[0,0];
            _Sort_by_wins();
            _Sort_by_draws();
            _Sort_by_losses();

            Textbox1.Text = Name[0] + " " + Name[1] + " " + Name[2] + " " + Name[3] + " " + Name[4] + " " + Name[5] + " " + Name[6] + " " + Name[7];
            //Textbox1.Text = Record[0, 0] + " " + Record[1, 0] + " " + Record[2, 0] + " " + Record[3, 0] + " " + Record[4, 0] + " " + Record[5, 0] + " " + Record[6, 0] + " " + Record[7, 0];

        }

        public Window1()
        {
            InitializeComponent();
            
        }
    }
}
