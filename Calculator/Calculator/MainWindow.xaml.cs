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
using System.Data;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void calculate(string str)
        {
            str.Split();
        }
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in MainGrid.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += ButtonClick;
                }
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //record in str clicked button
                string str = (string)((Button)e.OriginalSource).Content;


                if (str == "C")
                    textLabel.Text = "";
                else if (str == "=")
                    textLabel.Text = new DataTable().Compute(textLabel.Text, null).ToString();
                else
                    textLabel.Text += str;
            }
            catch
            {
                textLabel.Text = "Error!";
            }
            

            
        }
    }
}
