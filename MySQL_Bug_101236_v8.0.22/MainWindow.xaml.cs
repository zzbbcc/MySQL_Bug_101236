using MySQL_Bug_101236_v8._0._22.Model;
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

namespace MySQL_Bug_101236_v8._0._22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Model1 model1 = new Model1();
            var query = (from t in model1.table1 select t).ToArray();   // MySqlException: Table 'test.test.table1' doesn't exist
            Console.WriteLine();
        }
    }
}
