﻿using DataGridViewExample.Model;
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
    public partial class frmAddMarca : Form {
        public frmAddMarca() {
            InitializeComponent();
        }
        public Marca MarcasRow;

        private void BtAdicao_Click(object sender, EventArgs e) {
            MarcasRow = new Marca {
                Nome = txtNomeMarca.Text
            };
            this.Close();
        }
    }
}
