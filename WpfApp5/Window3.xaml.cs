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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (answerTB.Text.ToLower() == "Александрийский маяк")
            {
                Sum.count=Sum.count+3;
                resultWin window3 = new resultWin();
                window3.Show();
                this.Close();
            }
            else
            {
                resultWin window3 = new resultWin();
                window3.Show();
                this.Close();
            }
        }
    }
}
