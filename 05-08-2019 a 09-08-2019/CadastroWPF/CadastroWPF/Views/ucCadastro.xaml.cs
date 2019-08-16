using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CadastroWPF.Views {
    /// <summary>
    /// Interaction logic for ucCadastro.xaml
    /// </summary>
    public partial class ucCadastro : UserControl {
        public ucCadastro() {
            InitializeComponent();
        }
        private void BtSalvar_Click(object sender, RoutedEventArgs e) {
            string fone = txtFone.Text;
            string email = txtEmail.Text;

            var regexFone = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            var regexEmail = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex regF = new Regex(regexFone);
            if (regF.IsMatch(fone)) {
                MessageBox.Show("Telefone válido!");
            } else {
                MessageBox.Show("Telefone inválido!");
            }

            Regex regE = new Regex(regexEmail);
            if (regE.IsMatch(email)) {
                MessageBox.Show("Email válido!");
            } else {
                MessageBox.Show("Email inválido!");
            }

        }

        private void TxtFone_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}
