namespace GestionPretForm
{
    partial class FormLivre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label iSBNLabel;
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            titreLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // livreBindingSource
            // 
            this.livreBindingSource.DataSource = typeof(Bibliotheque.BOL.Livre);
            // 
            // livreDataGridView
            // 
            this.livreDataGridView.AutoGenerateColumns = false;
            this.livreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.livreDataGridView.DataSource = this.livreBindingSource;
            this.livreDataGridView.Location = new System.Drawing.Point(28, 171);
            this.livreDataGridView.Name = "livreDataGridView";
            this.livreDataGridView.Size = new System.Drawing.Size(552, 220);
            this.livreDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdCategorie";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdCategorie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categorie";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categorie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(25, 28);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(31, 13);
            titreLabel.TabIndex = 1;
            titreLabel.Text = "Titre:";
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "Titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(62, 25);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(100, 20);
            this.titreTextBox.TabIndex = 2;
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(21, 70);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 3;
            iSBNLabel.Text = "ISBN:";
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(62, 67);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.iSBNTextBox.TabIndex = 4;
            // 
            // FormLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 599);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(titreLabel);
            this.Controls.Add(this.titreTextBox);
            this.Controls.Add(this.livreDataGridView);
            this.Name = "FormLivre";
            this.Text = "FormLivre";
            this.Load += new System.EventHandler(this.FormLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource livreBindingSource;
        private System.Windows.Forms.DataGridView livreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
    }
}