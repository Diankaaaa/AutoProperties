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

namespace AutoProperties
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(A.Text);
            double b = double.Parse(B.Text);
            Equation d = new Equation(a,b);

            //Ситуации при решении линейного уравнения
            //1. Если а = 0, b = 0, то это уравнение имеет бесконечно много корней, а именно, любое число является корнем
            //2.Если a = 0, b != 0, то исходное уравнение не имеет корней
            //3.Если а != 0, то, x = -b/a

            if (a != 0)
            {
                OUTPUT.Text += "X = " + d.root(a,b) + Environment.NewLine + Environment.NewLine;
            }
            if(a == 0 && b != 0)
            {
                OUTPUT.Text += "Уравнение не имеет решений" + Environment.NewLine + Environment.NewLine;
            }
            if(a == 0 && b == 0)
            {
                OUTPUT.Text += "Уравнение имеет бесконечно много корней" + Environment.NewLine + Environment.NewLine;
            }
        }

        //Кнопка очистки поля
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OUTPUT.Text = String.Empty;
        }
    }
}
