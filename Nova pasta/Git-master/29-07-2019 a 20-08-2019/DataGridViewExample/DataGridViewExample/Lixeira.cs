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
    public partial class Lixeira : Form {
        public Lixeira() {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomInativeValues(this.querysInnerDataSet1.Carros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var carSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridViewExample.QuerysInnerDataSet1.CarrosRow;

            switch (e.ColumnIndex) {
                case 0: {
                        this.carrosTableAdapter.UpdateQuery(carSelect.Id);
                    }
                    break;
            }
            this.carrosTableAdapter.CustomInativeValues(this.querysInnerDataSet1.Carros);
        }
    }
    
}
