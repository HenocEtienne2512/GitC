using MVCProject.Model;
using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtLogin_Click(object sender, EventArgs e) {
            var Result = this.usuariosTableAdapter.LoginQuery(txtLogin.Text, txtSenha.Text);
            if (Result != null) {
                Session.User = new Usuario {
                    Id = (int)Result
                };
                frmPrincipal formPrincipal = new frmPrincipal();
                formPrincipal.ShowDialog();
            } else {
                throw new Exception("FUUUUUUUUUUUUUUUU");
            }

        }
    }
}
