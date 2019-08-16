namespace MVCProject.View {
    partial class LivroAtutor {
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
            this.cbLivro = new System.Windows.Forms.ComboBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbLivro
            // 
            this.cbLivro.FormattingEnabled = true;
            this.cbLivro.Location = new System.Drawing.Point(80, 52);
            this.cbLivro.Name = "cbLivro";
            this.cbLivro.Size = new System.Drawing.Size(352, 24);
            this.cbLivro.TabIndex = 0;
            // 
            // cbAutor
            // 
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(80, 108);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(352, 24);
            this.cbAutor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Livro : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor :";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(93, 161);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(295, 35);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "INSERIR";
            this.btSave.UseMnemonic = false;
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // LivroAtutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 277);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAutor);
            this.Controls.Add(this.cbLivro);
            this.Name = "LivroAtutor";
            this.Text = "LivroAtutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLivro;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
    }
}