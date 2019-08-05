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
    public partial class frmAutores : Form {
        public frmAutores() {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var autoresSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;
            switch (e.ColumnIndex) {
                case 0: {
                        this.autoresTableAdapter.DeleteQuery(autoresSelect.Id);
                    } break;
            }

            /*
             *  var marcasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerDataSet1.MarcasRow;

            switch (e.ColumnIndex) {
                case 0: {
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    } break;
                case 1: {
                        frmEdicaoMarca editMarca = new frmEdicaoMarca();
                        editMarca.MarcasRow = marcasSelect;
                        editMarca.ShowDialog();

                        this.marcasTableAdapter.Update(editMarca.MarcasRow);
                    } break;
            }
              this.marcasTableAdapter.CustomQuery(this.querysInnerDataSet1.Marcas);
        }
             */
        }
    }
}
