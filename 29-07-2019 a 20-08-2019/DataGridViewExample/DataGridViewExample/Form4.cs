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
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var vendasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerDataSet1.VendasRow;

            switch (e.ColumnIndex) {
                case 0: {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                  } break;
                case 1: {
                        frmEdicaoVendas editVendas = new frmEdicaoVendas();
                        editVendas.VendasRow = vendasSelect;
                        editVendas.ShowDialog();

                        this.vendasTableAdapter.Update(editVendas.VendasRow);
                    } break;
            }
             this.vendasTableAdapter.CustomQuery(this.querysInnerDataSet1.Vendas);
        }

        private void BtAddVendas_Click(object sender, EventArgs e) {
            frmAddVendas formVendas = new frmAddVendas();
            formVendas.ShowDialog();

            if (formVendas.VendasRow?.Carro > 0 && formVendas.VendasRow?.Valor > 0) {

                this.vendasTableAdapter.Insert(
                    formVendas.VendasRow.Carro,
                    formVendas.VendasRow.Quantidade,
                    formVendas.VendasRow.Valor,
                    formVendas.VendasRow.Ativo,
                    1,
                    1,
                    formVendas.VendasRow.DatInc,
                    formVendas.VendasRow.DatAlt
                    );
            }
        }
    }
}
