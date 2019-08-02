using DataGridViewExample.Adicao;
using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var marcasSelect = ((System.Data.DataRowView)
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

        private void BtAdicionar_Click(object sender, EventArgs e) {
            frmAddMarca addMarca = new frmAddMarca();
            addMarca.ShowDialog();
            if (!string.IsNullOrEmpty(addMarca.MarcasRow?.Nome)) { // Para não dar erro quando o campo está vazia
                this.marcasTableAdapter.Insert(
                    addMarca.MarcasRow.Nome,
                    true,
                    1,
                    1,
                    DateTime.Now,
                    DateTime.Now
                    );
            }
            // Atualiza a tabela
            this.marcasTableAdapter.Fill(this.querysInnerDataSet1.Marcas);
        }
    }
}
