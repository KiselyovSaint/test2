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
using TestDemo.ClassHelper;
using TestDemo.DB;

namespace TestDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvListUser.ItemsSource = EFClass.context.User.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                User user = button.DataContext as User;
                if (user != null)
                {
                    EFClass.context.User.Remove(user);
                    EFClass.context.SaveChanges();
                    lvListUser.ItemsSource = ClassHelper.EFClass.context.User.ToList();
                }
            }
        }
    }
}
