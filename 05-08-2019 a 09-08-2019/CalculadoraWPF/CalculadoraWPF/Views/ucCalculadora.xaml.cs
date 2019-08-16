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

namespace CalculadoraWPF.Views {
    /// <summary>
    /// Interaction logic for ucCalculadora.xaml
    /// </summary>
    public partial class ucCalculadora : UserControl {
        public ucCalculadora() {
            InitializeComponent();
        }

        private void Botao1_Click(object sender, RoutedEventArgs e) {
            Button botao1 = (Button)sender;
            txtDisplay.Text += botao1.Content.ToString();
        }
        private void Botao2_Click(object sender, RoutedEventArgs e) {
            Button botao2 = (Button)sender;
            txtDisplay.Text += botao2.Content.ToString();
        }

        private void Botao3_Click(object sender, RoutedEventArgs e) {
            Button botao3 = (Button)sender;
            txtDisplay.Text += botao3.Content.ToString();
        }

        private void Botao4_Click(object sender, RoutedEventArgs e) {
            Button botao4 = (Button)sender;
            txtDisplay.Text += botao4.Content.ToString();
        }

        private void Botao5_Click(object sender, RoutedEventArgs e) {
            Button botao5 = (Button)sender;
            txtDisplay.Text += botao5.Content.ToString();
        }

        private void Botao6_Click(object sender, RoutedEventArgs e) {
            Button botao6 = (Button)sender;
            txtDisplay.Text += botao6.Content.ToString();
        }

        private void Botao7_Click(object sender, RoutedEventArgs e) {
            Button botao7 = (Button)sender;
            txtDisplay.Text += botao7.Content.ToString();
        }

        private void Botao8_Click(object sender, RoutedEventArgs e) {
            Button botao8 = (Button)sender;
            txtDisplay.Text += botao8.Content.ToString();
        }

        private void Botao9_Click(object sender, RoutedEventArgs e) {
            Button botao9 = (Button)sender;
            txtDisplay.Text += botao9.Content.ToString();
        }

        private void Botao0_Click(object sender, RoutedEventArgs e) {
            Button botao0 = (Button)sender;
            txtDisplay.Text += botao0.Content.ToString();
        }

        private void Substrair_Click(object sender, RoutedEventArgs e) {
            Button Substrair = (Button)sender;
            txtDisplay.Text += Substrair.Content.ToString();
        }

        private void Somar_Click(object sender, RoutedEventArgs e) {
            Button Somar = (Button)sender;
            txtDisplay.Text += Somar.Content.ToString();
        }

        private void Multiplicar_Click(object sender, RoutedEventArgs e) {
            Button Multiplicar = (Button)sender;
            txtDisplay.Text += Multiplicar.Content.ToString();
        }

        private void Dividir_Click(object sender, RoutedEventArgs e) {
            Button Dividir = (Button)sender;
            txtDisplay.Text += Dividir.Content.ToString();
        }

        private void Limpar_Click(object sender, RoutedEventArgs e) {
            txtDisplay.Text = "";
        }

        private void Apagar_Click(object sender, RoutedEventArgs e) {
            if (txtDisplay.Text.Length > 0) {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Igual_Click(object sender, RoutedEventArgs e) {
            try {
                result();
            } catch (Exception exc) {
                txtDisplay.Text = "Error!";
            }
        }
        /// <summary>
        /// Metodo que faz as operações
        /// </summary>
        private void result() {
            String oper;
            int iOper = 0;
            if (txtDisplay.Text.Contains("+")) {
                iOper = txtDisplay.Text.IndexOf("+");
            } else if (txtDisplay.Text.Contains("-")) {
                iOper = txtDisplay.Text.IndexOf("-");
            } else if (txtDisplay.Text.Contains("*")) {
                iOper = txtDisplay.Text.IndexOf("*");
            } else if (txtDisplay.Text.Contains("/")) {
                iOper = txtDisplay.Text.IndexOf("/");
            } else {
                //error    
            }
            oper = txtDisplay.Text.Substring(iOper, 1);
            double op1 = Convert.ToDouble(txtDisplay.Text.Substring(0, iOper));
            double op2 = Convert.ToDouble(txtDisplay.Text.Substring(iOper + 1, txtDisplay.Text.Length - iOper - 1));

            if (oper == "+") {
                txtDisplay.Text += "=" + (op1 + op2);
            } else if (oper == "-") {
                txtDisplay.Text += "=" + (op1 - op2);
            } else if (oper == "*") {
                txtDisplay.Text += "=" + (op1 * op2);
            } else {
                txtDisplay.Text += "=" + (op1 / op2);
            }
        }
        /// <summary>
        /// Método que fecha totalmente a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoOff_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
