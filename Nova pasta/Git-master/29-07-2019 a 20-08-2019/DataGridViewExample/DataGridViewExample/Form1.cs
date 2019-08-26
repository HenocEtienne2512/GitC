using DataGridViewExample.Adicao;
using DataGridViewExample.Edicao;
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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'querysInnerDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerDataSet1.Carros);
            // TODO: This line of code loads data into the 'querysInnerDataSet.Carros' table. You can move, or remove it, as needed.

        }

        private void Button2_Click(object sender, EventArgs e) {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e) {
            Form3 frmUsuario = new Form3();
            frmUsuario.ShowDialog();
        }
        private void Button4_Click(object sender, EventArgs e) {
            Form4 frmVendas = new Form4();
            frmVendas.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            /*((System.Windows.Forms.DataGridViewRow)(new System.Collections
             * .ArrayList.ArrayListDebugView(((System.Windows.Forms.DataGridView)sender)
             * .Rows.items).Items[0])).DataBoundItem*/

            var carSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerDataSet1.CarrosRow;
            
            switch (e.ColumnIndex) {
                
                case 0: { /*TODO: Deletar*/
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                    }
                    break;
                case 1: {/*TODO: Editar*/
                        frmEdicaoCarros editCarro = new frmEdicaoCarros();
                        editCarro.CarrosRow = carSelect;
                        editCarro.ShowDialog();

                        this.carrosTableAdapter.Update(editCarro.CarrosRow);

                        /*
                        this.carrosTableAdapter.UpdateQuery1(
                            editCarro.CarrosRow.Modelo,
                            editCarro.CarrosRow.Ano.ToString(),
                            editCarro.CarrosRow.Marca,
                            editCarro.CarrosRow.UsuAlt,
                            DateTime.Now,
                            editCarro.CarrosRow.Id);*/
                    } break;
            }
            this.carrosTableAdapter.CustomQuery(this.querysInnerDataSet1.Carros);
        }

        private void Button5_Click(object sender, EventArgs e) {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();

            this.carrosTableAdapter.CustomQuery(this.querysInnerDataSet1.Carros);
        }

        private void Button1_Click(object sender, EventArgs e) {

            //Abre o formulario de atualização
            frmAdicionar formAdd = new frmAdicionar();
            formAdd.ShowDialog();

            //Insert na tabela do banco de dados de carros o novo registro
            if (!string.IsNullOrEmpty(formAdd.CarrosRow?.Modelo)) { // Para não dar erro quando o campo está vazia

                this.carrosTableAdapter.Insert(
                    formAdd.CarrosRow.Modelo,
                    formAdd.CarrosRow.Ano,
                    formAdd.CarrosRow.Marca,
                    true,
                    1,
                    1,
                    DateTime.Now,
                    DateTime.Now
                    );
            }
            //Atualiza a tabela
            this.carrosTableAdapter.FillBy(this.querysInnerDataSet1.Carros);
        }
    }
}
