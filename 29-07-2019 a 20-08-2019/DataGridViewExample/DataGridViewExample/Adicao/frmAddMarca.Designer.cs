namespace DataGridViewExample.Adicao {
    partial class frmAddMarca {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.btAdicao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Marca :";
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Location = new System.Drawing.Point(152, 25);
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(305, 22);
            this.txtNomeMarca.TabIndex = 1;
            // 
            // btAdicao
            // 
            this.btAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicao.Location = new System.Drawing.Point(162, 80);
            this.btAdicao.Name = "btAdicao";
            this.btAdicao.Size = new System.Drawing.Size(197, 32);
            this.btAdicao.TabIndex = 2;
            this.btAdicao.Text = "Adiciona";
            this.btAdicao.UseVisualStyleBackColor = true;
            this.btAdicao.Click += new System.EventHandler(this.BtAdicao_Click);
            // 
            // frmAddMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 215);
            this.Controls.Add(this.btAdicao);
            this.Controls.Add(this.txtNomeMarca);
            this.Controls.Add(this.label1);
            this.Name = "frmAddMarca";
            this.Text = "frmAddMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeMarca;
        private System.Windows.Forms.Button btAdicao;
    }
}