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
using TopBars.WPFClient;

namespace TopBarsWPFClient
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TopBarsViewModel currentViewModel = (TopBarsViewModel)DataContext;

           // TopBars.Business.MenuItem newItem = currentViewModel.NewMenuItem;
            foreach(var currentVM in currentViewModel.NewMenuItems)
            {
                currentViewModel.SelectedMenu.SaveNewMenuItem(currentVM.Title, currentVM.Description, currentVM.Price);
            }
           

            BindingOperations.GetBindingExpressionBase(cboAllMenus, ComboBox.ItemsSourceProperty).UpdateTarget();
        }

        private void DataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            TopBars.Business.MenuItem newMenuItem = e.Row.Item as TopBars.Business.MenuItem;
            if(newMenuItem != null && e.EditAction == DataGridEditAction.Commit && e.Row.IsNewItem)
            {
                TopBarsViewModel currentVM = (TopBarsViewModel)DataContext;
                currentVM.NewMenuItems.Add(newMenuItem);
            }
        }
    }
}
