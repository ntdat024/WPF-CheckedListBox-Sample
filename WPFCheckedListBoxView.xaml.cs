using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace OPENSOURCE.WPFCheckedListBox
{
    /// <summary>
    /// Interaction logic for WPFCheckedListBoxView.xaml
    /// </summary>
    public partial class WPFCheckedListBoxView : Window
    {
        public WPFCheckedListBoxView(List<CheckedListBoxItem> listItems)
        {
            InitializeComponent();
            lbx.ItemsSource = listItems;
        }

        private void btAll_Click(object sender, RoutedEventArgs e)
        {
            SelectAll(true);
        }

        private void btNone_Click(object sender, RoutedEventArgs e)
        {
            SelectAll(false);
        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in lbx.Items)
            {
                var clb = item as CheckedListBoxItem;
                if (clb.IsChecked)
                {
                    MessageBox.Show(clb.Name);
                }
            }
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void SelectAll(bool isChecked)
        {
            var tempList = new List<CheckedListBoxItem>();
            foreach (var item in lbx.Items)
            {
                (item as CheckedListBoxItem).IsChecked = isChecked;
                tempList.Add(item as CheckedListBoxItem);
            }
            lbx.ItemsSource = tempList;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var allItems = lbx.Items;
            var seletedItems = lbx.SelectedItems;
            var tempList = new List<CheckedListBoxItem>();

            if (sender is CheckBox checkBox)
            {
                foreach (var item in allItems)
                {
                    var clb = (CheckedListBoxItem)item;
                    if (seletedItems.Contains(item))
                    {
                        if (checkBox.IsChecked == true)
                        {
                            clb.IsChecked = true;
                        }
                        else clb.IsChecked = false;
                    }

                    tempList.Add(clb);
                }

                lbx.ItemsSource = tempList;
            }
        }
    }
}
