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

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
            CalcularButton.IsEnabled = false;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int operacion = default;
                switch (OperadorTexbox.Text)
                {
                    case "+":
                        operacion = int.Parse(Operando1Texbox.Text) + int.Parse(Operando2Texbox.Text);
                        break;
                    case "-":
                        operacion = int.Parse(Operando1Texbox.Text) - int.Parse(Operando2Texbox.Text);
                        break;
                    case "*":
                        operacion = int.Parse(Operando1Texbox.Text) * int.Parse(Operando2Texbox.Text);
                        break;
                    case "/":
                        operacion = int.Parse(Operando1Texbox.Text) / int.Parse(Operando2Texbox.Text);
                        break;
                    default:
                        break;

                }
                ResultadoTexbox.Text = operacion.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error, revise los operandos",
                                   "Error", MessageBoxButton.OK);

            }
        }

        private void OperadorTexbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalcularButton.IsEnabled = OperadorTexbox.Text == "+" || OperadorTexbox.Text == "-" || OperadorTexbox.Text == "*" || OperadorTexbox.Text == "/";
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1Texbox.Clear();
            Operando2Texbox.Clear();
            OperadorTexbox.Clear();
            ResultadoTexbox.Clear();
        }
    }
}
