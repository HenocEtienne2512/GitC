using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfAppEntity.Data;

namespace WpfAppEntity.Views {
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl {
        public ucLogin() {
            InitializeComponent();
        }
        public event EventHandler sucess;
        public event EventHandler fail;

        public BibliotecaDBContext context = new BibliotecaDBContext();

        private void Button_Click(object sender, RoutedEventArgs e) {
            var userName = txtLogin.Text;
            var userPass = txtSenha.Password;

            var result = context.Usuarios
                .FirstOrDefault (x => 
                x.Login == userName 
                && x.Senha == userPass);

            if (result?.Id > 0) {
                sucess("Usuario logado com sucesso!!", new EventArgs());
            } else {
                fail($"Falha ao logar com usuário{userName}.", new EventArgs());
            }
        }
    }
}
