namespace DataGridViewExample.Adicao {
    partial class frmAdicionar {
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
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerAno = new System.Windows.Forms.DateTimePicker();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.querysInnerDataSet1 = new DataGridViewExample.QuerysInnerDataSet1();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new DataGridViewExample.QuerysInnerDataSet1TableAdapters.MarcasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano :";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(129, 33);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(229, 22);
            this.txtModelo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca :";
            // 
            // dateTimePickerAno
            // 
            this.dateTimePickerAno.Location = new System.Drawing.Point(129, 80);
            this.dateTimePickerAno.Name = "dateTimePickerAno";
            this.dateTimePickerAno.Size = new System.Drawing.Size(229, 22);
            this.dateTimePickerAno.TabIndex = 4;
            // 
            // cbMarca
            // 
            this.cbMarca.DataSource = this.marcasBindingSource;
            this.cbMarca.DisplayMember = "Nome";
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(129, 119);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(232, 24);
            this.cbMarca.TabIndex = 5;
            this.cbMarca.ValueMember = "Id";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(149, 191);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(177, 28);
            this.btAdicionar.TabIndex = 6;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // querysInnerDataSet1
            // 
            this.querysInnerDataSet1.DataSetName = "QuerysInnerDataSet1";
            this.querysInnerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.querysInnerDataSet1;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 265);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.dateTimePickerAno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdicionar";
            this.Text = "frmAdicionar";
            this.Load += new System.EventHandler(this.FrmAdicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerAno;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btAdicionar;
        private QuerysInnerDataSet1 querysInnerDataSet1;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private QuerysInnerDataSet1TableAdapters.MarcasTableAdapter marcasTableAdapter;
    }
}