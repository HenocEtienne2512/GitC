using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicao {
    public partial class frmAddVendas : Form {
        public frmAddVendas() {
            InitializeComponent();
        }
        public Venda VendasRow;


        private void FrmAddVendas_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerDataSet1.Carros);

        }
        private void BtAdicao_Click(object sender, EventArgs e) {
            var valor = decimal.Parse(txtValor.Text);
            VendasRow = new Venda {
                Carro = (int)cbCarro.SelectedValue,
                Quantidade = (int)nrQuant.Value,
                Valor = valor
            };
            this.Close();
        }
    }
}
