namespace GestionPretForm
{
    partial class FormModifyBook
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
            System.Windows.Forms.Label idCategorieLabel;
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label libelleLabel;
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.idCategorieTextBox = new System.Windows.Forms.TextBox();
            this.exemplairesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libelleComboBox = new System.Windows.Forms.ComboBox();
            idCategorieLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            libelleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exemplairesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idCategorieLabel
            // 
            idCategorieLabel.AutoSize = true;
            idCategorieLabel.Location = new System.Drawing.Point(20, 87);
            idCategorieLabel.Name = "idCategorieLabel";
            idCategorieLabel.Size = new System.Drawing.Size(67, 13);
            idCategorieLabel.TabIndex = 11;
            idCategorieLabel.Text = "Id Categorie:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(20, 61);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(31, 13);
            titreLabel.TabIndex = 15;
            titreLabel.Text = "Titre:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(23, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(195, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // idCategorieTextBox
            // 
            this.idCategorieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exemplairesBindingSource, "Livre.IdCategorie", true));
            this.idCategorieTextBox.Location = new System.Drawing.Point(93, 84);
            this.idCategorieTextBox.Name = "idCategorieTextBox";
            this.idCategorieTextBox.Size = new System.Drawing.Size(177, 20);
            this.idCategorieTextBox.TabIndex = 12;
            // 
            // exemplairesBindingSource
            // 
            this.exemplairesBindingSource.DataSource = typeof(Bibliotheque.BOL.Exemplaire);
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exemplairesBindingSource, "Livre.Titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(93, 58);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(177, 20);
            this.titreTextBox.TabIndex = 16;
            // 
            // livreBindingSource
            // 
            this.livreBindingSource.DataSource = typeof(Bibliotheque.BOL.Livre);
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(Bibliotheque.BOL.Categorie);
            // 
            // libelleLabel
            // 
            libelleLabel.AutoSize = true;
            libelleLabel.Location = new System.Drawing.Point(47, 34);
            libelleLabel.Name = "libelleLabel";
            libelleLabel.Size = new System.Drawing.Size(40, 13);
            libelleLabel.TabIndex = 16;
            libelleLabel.Text = "Libelle:";
            // 
            // libelleComboBox
            // 
            this.libelleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorieBindingSource, "Libelle", true));
            this.libelleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.categorieBindingSource, "Libelle", true));
            this.libelleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livreBindingSource, "Categorie", true));
            this.libelleComboBox.DataSource = this.livreBindingSource;
            this.libelleComboBox.DisplayMember = "Categorie";
            this.libelleComboBox.FormattingEnabled = true;
            this.libelleComboBox.Location = new System.Drawing.Point(93, 31);
            this.libelleComboBox.Name = "libelleComboBox";
            this.libelleComboBox.Size = new System.Drawing.Size(177, 21);
            this.libelleComboBox.TabIndex = 17;
            this.libelleComboBox.ValueMember = "Categorie";
            // 
            // FormModifyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 311);
            this.Controls.Add(libelleLabel);
            this.Controls.Add(this.libelleComboBox);
            this.Controls.Add(idCategorieLabel);
            this.Controls.Add(this.idCategorieTextBox);
            this.Controls.Add(titreLabel);
            this.Controls.Add(this.titreTextBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormModifyBook";
            this.Text = "FormModifyBook";
            ((System.ComponentModel.ISupportInitialize)(this.exemplairesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource exemplairesBindingSource;
        public System.Windows.Forms.TextBox titreTextBox;
        public System.Windows.Forms.TextBox idCategorieTextBox;
        private System.Windows.Forms.BindingSource livreBindingSource;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.ComboBox libelleComboBox;
    }
}