﻿using DataGridViewExample.Edicao;
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
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
                var usuarioSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerDataSet1.UsuariosRow;

            switch (e.ColumnIndex) {
                case 0: {
                        this.usuariosTableAdapter.DeleteQuery(usuarioSelect.Id);
                    }
                    break;
                case 1: {
                        frmEdicaoUsuario editUsuario = new frmEdicaoUsuario();
                        editUsuario.UsuariosRow = usuarioSelect;
                        editUsuario.ShowDialog();

                   this.usuariosTableAdapter.Update(editUsuario.UsuariosRow);
                    } break;
            }

            this.usuariosTableAdapter.CustomQuery(this.querysInnerDataSet1.Usuarios);
        }
    }
}