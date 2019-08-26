using MVCProject.Model;
using MVCProject.View.Editar;
using MVCProject.View.Inserir;
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
    public partial class frmLivros : Form {
        public frmLivros() {
            InitializeComponent();
        }
        private void Livros_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var livrosSelect = ((System.Data.DataRowView)
             this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
             as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;
            switch (e.ColumnIndex) {
                case 0: {
                        this.livrosTableAdapter.DeleteQuery(livrosSelect.Id);
                        

                }break;
                case 1: {
                        frmEditLivros livroEdit = new frmEditLivros();
                        livroEdit.LivrosRow = livrosSelect;
                        livroEdit.ShowDialog();


                        this.livrosTableAdapter.Update(livroEdit.LivrosRow);
                    }
                    break;
            }

            this.livrosTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Livros);
        }
        

        private void BtAdicionar_Click(object sender, EventArgs e) {
            
            frmAddLivros livroAdd = new frmAddLivros();
            livroAdd.ShowDialog();
            
            if (livroAdd.livroRow?.Registro > 0) {
                this.livrosTableAdapter.Insert(
                                    livroAdd.livroRow.Registro,
                                    livroAdd.livroRow.Titulo,
                                    livroAdd.livroRow.Isbn,
                                    livroAdd.livroRow.Genero,
                                    livroAdd.livroRow.Editora,
                                    livroAdd.livroRow.Sinopse,
                                    livroAdd.livroRow.Observacoes,
                                    true,
                                    1,
                                    1,
                                    DateTime.Now,
                                    DateTime.Now);
            }
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }
    }
}
