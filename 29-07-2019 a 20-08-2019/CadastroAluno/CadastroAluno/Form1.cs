using CadastroAluno.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAluno {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        List<Cadastro> cadastros = new List<Cadastro>();

        private void Button1_Click(object sender, EventArgs e) {
            AlunoCad frmCad = new AlunoCad();
            frmCad.ShowDialog();
            cadastros.Add(frmCad.NovoCadastro);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cadastros;
        }
    }
}
