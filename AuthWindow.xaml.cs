﻿using System;
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
using TestDemo.ClassHelper;

namespace TestDemo.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var authUser = ClassHelper.EFClass.context.User.ToList().Where(i => i.Login == txbLogin.Text && i.Password == pwbPassword.Password).FirstOrDefault();
            if (authUser != null)
            {
                MessageBox.Show("Успех!");
            }
            else
            {
                MessageBox.Show("Неудача!");
            }
        }

        private void btnRegIn_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            this.Close();
        }
    }
}
