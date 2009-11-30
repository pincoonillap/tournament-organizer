using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

// NOTE: The original concept of this demo was created by Sacha Barber, in
// this article: http://www.codeproject.com/useritems/WPF_Explorer_Tree.asp

namespace WpfExplorerTreeNoConverter
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>

	public partial class Window1 : System.Windows.Window
	{
		private readonly object _dummyNode = null;

		public Window1()
		{
			InitializeComponent();
			this.Loaded += new RoutedEventHandler(Window1_Loaded);
		}

		void Window1_Loaded(object sender, RoutedEventArgs e)
		{
			foreach (string drive in Directory.GetLogicalDrives())
			{
				TreeViewItem item = new TreeViewItem();
				item.Header = drive;
				item.Tag = drive;
				item.Items.Add(_dummyNode);
				item.Expanded += folder_Expanded;

				// Apply the attached property so that 
				// the triggers know that this is root item.
				TreeViewItemProps.SetIsRootLevel(item, true);

				foldersTree.Items.Add(item);
			}
		}

		void folder_Expanded(object sender, RoutedEventArgs e)
		{
			TreeViewItem item = (TreeViewItem)sender;
			if (item.Items.Count == 1 && item.Items[0] == _dummyNode)
			{
				item.Items.Clear();
				try
				{					
					foreach (string dir in Directory.GetDirectories(item.Tag as string))
					{
						TreeViewItem subitem = new TreeViewItem();
						subitem.Header = new DirectoryInfo(dir).Name;
						subitem.Tag = dir;
						subitem.Items.Add(_dummyNode);
						subitem.Expanded += folder_Expanded;
						item.Items.Add(subitem);
					}
				}
				catch (Exception) { }
			}
		}
	}
}