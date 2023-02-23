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

namespace BYTE
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
            byte primer_valor; //elementos de lenguaje
            int segundo_valor;
            byte tercer_valor;
            decimal resultado;
            if (int.Parse(textBox1.Text) < 0 || (int.Parse(textBox1.Text) > 255))
                MessageBox.Show("Valor incorrecto (0-255)");
            else if
                (double.Parse(textBox2.Text) < -2147483648 || (int.Parse(textBox4.Text) > 2147483647))
                MessageBox.Show("Valor incorrecto (0-255)");
            else
            {
                primer_valor = Convert.ToByte(textBox1.Text); // byte.Parse(textBox1.Text);
                tercer_valor = Convert.ToByte(textBox4.Text);
                segundo_valor = Convert.ToInt32(textBox2.Text); // int.Parse(textBox2.Text);
                resultado = primer_valor + segundo_valor + tercer_valor;
                textBox3.Text = resultado.ToString();
            }
        }
    }
}
