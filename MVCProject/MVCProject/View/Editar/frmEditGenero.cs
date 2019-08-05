using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar {
    public partial class frmEditGenero : Form {
        public frmEditGenero() {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow GenerosRow;

        private void BtSave_Click(object sender, EventArgs e) {
            GenerosRow.Tipo = txtTipo.Text;
            GenerosRow.Descricao = txtDesc.Text;

            this.Close();
        }
    }
}
