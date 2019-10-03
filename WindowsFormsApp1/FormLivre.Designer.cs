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
            System.Windows.Forms.Label idCategorieLabel;
            this.livreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModifyBook = new System.Windows.Forms.Button();
            this.idCategorieTextBox = new System.Windows.Forms.TextBox();
            this.btnAjouterLivre = new System.Windows.Forms.Button();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            titreLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            idCategorieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(25, 76);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 3;
            iSBNLabel.Text = "ISBN:";
            // 
            // idCategorieLabel
            // 
            idCategorieLabel.AutoSize = true;
            idCategorieLabel.Location = new System.Drawing.Point(25, 113);
            idCategorieLabel.Name = "idCategorieLabel";
            idCategorieLabel.Size = new System.Drawing.Size(67, 13);
            idCategorieLabel.TabIndex = 6;
            idCategorieLabel.Text = "Id Categorie:";
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
            // livreBindingSource
            // 
            this.livreBindingSource.DataSource = typeof(Bibliotheque.BOL.Livre);
            // 
            // titreTextBox
            // 
            this.titreTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.titreTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "Titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(98, 28);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(198, 20);
            this.titreTextBox.TabIndex = 2;
            this.titreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TitreTextBox_KeyDown);
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(98, 69);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(198, 20);
            this.iSBNTextBox.TabIndex = 4;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnModifyBook
            // 
            this.btnModifyBook.Enabled = false;
            this.btnModifyBook.Location = new System.Drawing.Point(384, 22);
            this.btnModifyBook.Name = "btnModifyBook";
            this.btnModifyBook.Size = new System.Drawing.Size(153, 23);
            this.btnModifyBook.TabIndex = 5;
            this.btnModifyBook.Text = "Modifier livre";
            this.btnModifyBook.UseVisualStyleBackColor = true;
            this.btnModifyBook.Click += new System.EventHandler(this.BtnModifyBook_Click);
            // 
            // idCategorieTextBox
            // 
            this.idCategorieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "IdCategorie", true));
            this.idCategorieTextBox.Location = new System.Drawing.Point(98, 110);
            this.idCategorieTextBox.Name = "idCategorieTextBox";
            this.idCategorieTextBox.Size = new System.Drawing.Size(198, 20);
            this.idCategorieTextBox.TabIndex = 7;
            // 
            // btnAjouterLivre
            // 
            this.btnAjouterLivre.Location = new System.Drawing.Point(384, 65);
            this.btnAjouterLivre.Name = "btnAjouterLivre";
            this.btnAjouterLivre.Size = new System.Drawing.Size(153, 23);
            this.btnAjouterLivre.TabIndex = 8;
            this.btnAjouterLivre.Text = "Ajouter livre";
            this.btnAjouterLivre.UseVisualStyleBackColor = true;
            this.btnAjouterLivre.Click += new System.EventHandler(this.BtnAjouterLivre_Click);
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(Bibliotheque.BOL.Categorie);
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Bibliotheque.BOL.Adherent);
            // 
            // FormLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 540);
            this.Controls.Add(this.btnAjouterLivre);
            this.Controls.Add(idCategorieLabel);
            this.Controls.Add(this.idCategorieTextBox);
            this.Controls.Add(this.btnModifyBook);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(titreLabel);
            this.Controls.Add(this.titreTextBox);
            this.Controls.Add(this.livreDataGridView);
            this.Name = "FormLivre";
            this.Text = "-";
            this.Load += new System.EventHandler(this.FormLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
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
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnModifyBook;
        private System.Windows.Forms.TextBox idCategorieTextBox;
        private System.Windows.Forms.Button btnAjouterLivre;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.BindingSource adherentBindingSource;
    }
}