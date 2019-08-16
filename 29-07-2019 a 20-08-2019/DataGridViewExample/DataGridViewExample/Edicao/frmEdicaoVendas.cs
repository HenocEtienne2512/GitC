using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao {
    public partial class frmEdicaoVendas : Form {
        public frmEdicaoVendas() {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerDataSet1.VendasRow VendasRow;

        private void FrmEdicaoVendas_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Vendas' table. You can move, or remove it, as needed.
           // this.vendasTableAdapter.Fill(this.querysInnerDataSet1.Vendas);
            this.carrosTableAdapter.FillBy1(this.querysInnerDataSet1.Carros);

            cbCarro.SelectedValue = VendasRow.Carro;
            txtQuant.Text = VendasRow.Quantidade.ToString();
            txtValor.Text = VendasRow.Valor.ToString();
        }

        private void BtSalvar_Click(object sender, EventArgs e) {
            VendasRow.Carro = (int)cbCarro.SelectedValue;
            VendasRow.Quantidade = int.Parse(txtQuant.Text);
            VendasRow.Valor  = decimal.Parse(txtValor.Text);

            this.Close();
        }

    }
}
