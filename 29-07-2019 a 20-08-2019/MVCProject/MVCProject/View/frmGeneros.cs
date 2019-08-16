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
    public partial class frmGeneros : Form {
        public frmGeneros() {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var generosSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;
            switch (e.ColumnIndex) {
                case 0: {
                        this.generosTableAdapter.DeleteQuery(generosSelect.Id);
                    }
                    break;
            }
        }
    }
}
