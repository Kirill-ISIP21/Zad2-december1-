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

namespace Zad2_december1_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Class1> list = new List<Class1>();
            Class1 triangle1 = new Class1(10, 10, 10);
            Class1 triangle2 = new Class1(3, 4, 5);
            Class1 triangle3 = new Class1(4, 5, 7);
            list.Add(triangle1);
            list.Add(triangle2);
            list.Add(triangle3);
            triangle1.trianglesCount(list);
        }
    }
}
