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
using System.Windows.Shapes;
using WPF.MDI;
using GUI_WPF_cs.Content;

namespace GUI_WPF_cs
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void MenuItem_New(object sender, RoutedEventArgs e)
        {
            MainContent.Children.Add(new MdiChild()
            {
                Title = "Window New",
                Name = "WindowNew",
                Height = 468,
                Width = 463,
                Content = new stuffNew()
            });
        }

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {
            MainContent.Children.Add(new MdiChild()
            {
                Title = "Window Open",
                Name = "WindowOpen",
                Height = 468,
                Width = 463,
                Content = new stuffOpen()
            });
        }

        private void MenuItem_Save(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
