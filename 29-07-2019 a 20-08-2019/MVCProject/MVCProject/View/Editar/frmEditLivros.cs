using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar {
    public partial class frmEditLivros : Form {
        public frmEditLivros() {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;


        private void FrmEditLivros_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            txtTitulo.Text = LivrosRow.Titulo;
            txtRegistro.Text = LivrosRow.Registro.ToString();
            txtISBN.Text = LivrosRow.Isbn;
            txtSinopse.Text = LivrosRow.Sinopse;
            txtObs.Text = LivrosRow.Observacoes;

        }

        private void BtSave_Click(object sender, EventArgs e) {
            LivrosRow.Titulo = txtTitulo.Text;
            LivrosRow.Registro = int.Parse(txtRegistro.Text);
            LivrosRow.Isbn = txtISBN.Text;
            LivrosRow.Sinopse = txtSinopse.Text;
            LivrosRow.Observacoes = txtObs.Text;

            this.Close();
        }
    }
}
