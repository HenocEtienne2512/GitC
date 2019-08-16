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
    public partial class frmEdicaoMarca : Form {
        public frmEdicaoMarca() {
            InitializeComponent();
        }
        public DataGridViewExample.QuerysInnerDataSet1.MarcasRow MarcasRow;

        private void FrmEdicaoMarca_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.querysInnerDataSet1.Marcas);

            txtNomeMarca.Text = MarcasRow.Nome;
        }

        private void BtSalvar_Click(object sender, EventArgs e) {
            MarcasRow.Nome = txtNomeMarca.Text;

            this.Close();
        }
    }
}
