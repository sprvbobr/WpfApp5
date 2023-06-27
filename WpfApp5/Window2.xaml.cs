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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)cb1.IsChecked && (bool)cb2.IsChecked)
            {
                Sum.count=Sum.count+2;
                Window3 window2 =new Window3();
                window2.Show();
                this.Close();
            }
            else
            {
                Window3 window2 = new Window3();
                window2.Show();
                this.Close();
            }
        }
    }
}
