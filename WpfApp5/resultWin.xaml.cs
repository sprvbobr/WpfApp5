using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Логика взаимодействия для resultWin.xaml
    /// </summary>
    public partial class resultWin : Window
    {
        public resultWin()
        {
            InitializeComponent();
            double procent = (100 / 6) * Sum.count;
            if (procent > 80)
            {
                resullb.Content = $"вы набрали{procent} процентов ({Sum.count}/6 ballov).5.   ";
            }
            else
            {
                if (procent > 50)
                {
                    resullb.Content = $"вы набрали{procent} процентов ({Sum.count}/6 ballov).4.   ";

                }
                else
                {
                    if (procent > 30)
                    {
                        resullb.Content = $"вы набрали{procent} процентов ({Sum.count}/6 ballov).3.   ";
                    }
                    else
                    {
                        resullb.Content = $"вы набрали{procent} процентов ({Sum.count}/6 ballov).2.   ";
                    }
                }



            }
        }
    }
}
