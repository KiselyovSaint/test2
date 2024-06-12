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
using System.Windows.Shapes;
using TestDemo.DB;

namespace TestDemo.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            cmbGender.ItemsSource = ClassHelper.EFClass.context.Gender.ToList();
            cmbGender.DisplayMemberPath = "NamGender";
            cmbGender.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();

            user.FName = txbFName.Text;
            user.LName = txbLName.Text;
            user.Login = txbLogin.Text;
            user.Password = pwbPassword.Password;
            user.Birthday = dpBirthday.SelectedDate.Value;
            user.IDGender = (cmbGender.SelectedItem as Gender).ID;

            ClassHelper.EFClass.context.User.Add(user);
            ClassHelper.EFClass.context.SaveChanges();

            MessageBox.Show("Gotovo");
        }
    }
}
