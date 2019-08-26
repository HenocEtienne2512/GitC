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
    public partial class frmEdicaoCarros : Form {
        public frmEdicaoCarros() {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerDataSet1.CarrosRow CarrosRow;

        private void FrmEdicaoCarros_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.FillBy(this.querysInnerDataSet1.Marcas);

            txtModelo.Text = CarrosRow.Modelo;
            dateTimePickerAno.Value = CarrosRow.Ano;
            cbMarca.SelectedValue = CarrosRow.Marca;

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.marcasTableAdapter.FillBy(this.querysInnerDataSet1.Marcas);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e) {
            CarrosRow.Modelo = txtModelo.Text;
            CarrosRow.Ano = dateTimePickerAno.Value;
            CarrosRow.Marca = (int) cbMarca.SelectedValue;

            this.Close();
        }
    }
}
