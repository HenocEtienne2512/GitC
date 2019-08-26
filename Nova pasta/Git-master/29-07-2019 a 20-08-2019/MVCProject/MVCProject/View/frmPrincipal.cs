using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
            
            if (Session.User == null) {
                throw new Exception("Erro critico do sitema!");
            }
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e) {
            frmUsuarios formUsu = new frmUsuarios();
            formUsu.ShowDialog();

        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAutores formAutor = new frmAutores();
            formAutor.ShowDialog();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e) {
            frmGeneros formGenero = new frmGeneros();
            formGenero.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e) {
            frmLivros formLivro = new frmLivros();
            formLivro.ShowDialog();
        }

        private void LocaçõesToolStripMenuItem_Click(object sender, EventArgs e) {
            frmLocacoes formLocacao = new frmLocacoes();
            formLocacao.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e) {
            frmEditoras formEditor = new frmEditoras();
            formEditor.ShowDialog();
        }
    }
}
