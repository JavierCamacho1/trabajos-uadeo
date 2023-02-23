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

namespace mes_del_año
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int mesdelaño = 0;
            textBox2.Text = null;
            {
                if (int.Parse(textBox1.Text) == 3 || (int.Parse(textBox1.Text) == 4 || (int.Parse(textBox1.Text) == 5))) textBox2.Text = ("PRIMAVERA");
                else if
                    (int.Parse(textBox1.Text) == 6 ||
                    (int.Parse(textBox1.Text) == 7 ||
                    (int.Parse(textBox1.Text) == 8))) textBox2.Text = ("VERANO");
                else if
                    (int.Parse(textBox1.Text) == 9 ||
                    (int.Parse(textBox1.Text) == 10 ||
                    (int.Parse(textBox1.Text) == 11))) textBox2.Text = ("OTOÑO");
                else if
                    (int.Parse(textBox1.Text) == 1 ||
                    (int.Parse(textBox1.Text) == 2 ||
                    (int.Parse(textBox1.Text) == 12))) textBox2.Text = ("INVIERNO");
                else
                {
                    if (mesdelaño < 1 || mesdelaño > 12)
                    {
                        MessageBox.Show("El numero no se encuentra en el rango de los meses");
                    }


                }

                

                

                    
                   
                   
            }
        }
    }
}
