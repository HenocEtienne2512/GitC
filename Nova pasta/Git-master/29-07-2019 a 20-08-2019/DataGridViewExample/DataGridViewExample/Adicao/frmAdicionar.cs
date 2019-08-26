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
    public partial class frmAdicionar : Form {
        public frmAdicionar() {
            InitializeComponent();
        }
        public Carro CarrosRow;

        private void FrmAdicionar_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.querysInnerDataSet1.Marcas);

        }

        private void BtAdicionar_Click(object sender, EventArgs e) {
            CarrosRow = new Carro {
                Modelo = txtModelo.Text,
                Ano = dateTimePickerAno.Value,
                Marca = (int)cbMarca.SelectedValue
        };
            this.Close();

        }
    }
}
