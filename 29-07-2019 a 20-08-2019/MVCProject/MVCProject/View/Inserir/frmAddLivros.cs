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

namespace MVCProject.View.Inserir {
    public partial class frmAddLivros : Form {
        public frmAddLivros() {
            InitializeComponent();
        }

        public Livro livroRow;
        private void FrmAddLivros_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void BtAdicionar_Click(object sender, EventArgs e) {
                livroRow = new Livro {

                Registro = int.Parse(txtRegistro.Text),
                Titulo = txtTitulo.Text,
                Isbn = txtISBN.Text,
                Genero = (int)cbGenero.SelectedValue,
                Editora = (int)cbEditora.SelectedValue,
                Sinopse = txtSinopse.Text,
                Observacoes = txtObs.Text
            };
            this.Close();

        }

      
    }
}
