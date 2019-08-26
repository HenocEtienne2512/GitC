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
    public partial class frmEdicaoUsuario : Form {
        public frmEdicaoUsuario() {
            InitializeComponent();
        }
        public DataGridViewExample.QuerysInnerDataSet1.UsuariosRow UsuariosRow;

        private void BtSalvar_Click(object sender, EventArgs e) {
            UsuariosRow.Usuario = txtNomeUsu.Text;

            this.Close();
        }
    }
}
