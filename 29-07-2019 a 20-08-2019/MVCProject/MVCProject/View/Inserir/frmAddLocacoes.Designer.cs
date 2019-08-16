namespace MVCProject.View.Inserir {
    partial class frmAddLocacoes {
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
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.cbLivro = new System.Windows.Forms.ComboBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.dateTPDev = new System.Windows.Forms.DateTimePicker();
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(136, 130);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(319, 22);
            this.txtTipo.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tipo : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Usuário : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Livro : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Devolução: ";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.Location = new System.Drawing.Point(142, 237);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(176, 38);
            this.btAdicionar.TabIndex = 48;
            this.btAdicionar.Text = "Inserir";
            this.btAdicionar.UseVisualStyleBackColor = true;
            // 
            // cbLivro
            // 
            this.cbLivro.DataSource = this.livrosBindingSource;
            this.cbLivro.DisplayMember = "Titulo";
            this.cbLivro.FormattingEnabled = true;
            this.cbLivro.Location = new System.Drawing.Point(136, 32);
            this.cbLivro.Name = "cbLivro";
            this.cbLivro.Size = new System.Drawing.Size(319, 24);
            this.cbLivro.TabIndex = 52;
            this.cbLivro.ValueMember = "Id";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DataSource = this.usuariosBindingSource;
            this.cbUsuario.DisplayMember = "Nome";
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(136, 77);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(319, 24);
            this.cbUsuario.TabIndex = 53;
            this.cbUsuario.ValueMember = "Id";
            // 
            // dateTPDev
            // 
            this.dateTPDev.Location = new System.Drawing.Point(136, 179);
            this.dateTPDev.Name = "dateTPDev";
            this.dateTPDev.Size = new System.Drawing.Size(319, 22);
            this.dateTPDev.TabIndex = 54;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddLocacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 303);
            this.Controls.Add(this.dateTPDev);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.cbLivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddLocacoes";
            this.Text = "frmAddLocacoes";
            this.Load += new System.EventHandler(this.FrmAddLocacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.ComboBox cbLivro;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.DateTimePicker dateTPDev;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}