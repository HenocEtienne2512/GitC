namespace DataGridViewExample.Adicao {
    partial class frmAddVendas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCarro = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.nrQuant = new System.Windows.Forms.NumericUpDown();
            this.btAdicao = new System.Windows.Forms.Button();
            this.querysInnerDataSet1 = new DataGridViewExample.QuerysInnerDataSet1();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new DataGridViewExample.QuerysInnerDataSet1TableAdapters.CarrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor :";
            // 
            // cbCarro
            // 
            this.cbCarro.DataSource = this.carrosBindingSource;
            this.cbCarro.DisplayMember = "Modelo";
            this.cbCarro.FormattingEnabled = true;
            this.cbCarro.Location = new System.Drawing.Point(163, 59);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(265, 24);
            this.cbCarro.TabIndex = 4;
            this.cbCarro.ValueMember = "Id";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(163, 157);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(265, 22);
            this.txtValor.TabIndex = 5;
            // 
            // nrQuant
            // 
            this.nrQuant.Location = new System.Drawing.Point(162, 110);
            this.nrQuant.Name = "nrQuant";
            this.nrQuant.Size = new System.Drawing.Size(266, 22);
            this.nrQuant.TabIndex = 6;
            // 
            // btAdicao
            // 
            this.btAdicao.Location = new System.Drawing.Point(163, 213);
            this.btAdicao.Name = "btAdicao";
            this.btAdicao.Size = new System.Drawing.Size(215, 38);
            this.btAdicao.TabIndex = 7;
            this.btAdicao.Text = "Adicionar";
            this.btAdicao.UseVisualStyleBackColor = true;
            this.btAdicao.Click += new System.EventHandler(this.BtAdicao_Click);
            // 
            // querysInnerDataSet1
            // 
            this.querysInnerDataSet1.DataSetName = "QuerysInnerDataSet1";
            this.querysInnerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.querysInnerDataSet1;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 326);
            this.Controls.Add(this.btAdicao);
            this.Controls.Add(this.nrQuant);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cbCarro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddVendas";
            this.Text = "frmAddVendas";
            this.Load += new System.EventHandler(this.FrmAddVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCarro;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.NumericUpDown nrQuant;
        private System.Windows.Forms.Button btAdicao;
        private QuerysInnerDataSet1 querysInnerDataSet1;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private QuerysInnerDataSet1TableAdapters.CarrosTableAdapter carrosTableAdapter;
    }
}