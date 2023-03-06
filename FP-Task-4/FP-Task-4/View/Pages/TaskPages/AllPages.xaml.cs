using FP_Task_4.Core;
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

namespace FP_Task_4.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для AllPages.xaml
    /// </summary>
    public partial class AllPages : Page
    {
        public AllPages()
        {
            InitializeComponent();
        }

        private void Btn_Click1(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }
    }
}
