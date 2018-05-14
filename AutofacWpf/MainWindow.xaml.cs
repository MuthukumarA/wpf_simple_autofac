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

namespace AutofacWpf
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
       
    }
    public class MainWindowViewModel
    {
        public MainWindowViewModel(IDataService dataService)
        {

        }
    }
    public interface IDataService
    {
        bool Data { get; set; }
    }

    public class DataService : IDataService
    {
        public bool Data { get; set; } = true;
    }
}
