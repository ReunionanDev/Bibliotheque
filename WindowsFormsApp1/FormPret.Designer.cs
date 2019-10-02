namespace GestionPretForm
{
    partial class FormPret
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label prenomLabel1;
            System.Windows.Forms.Label nomLabel1;
            System.Windows.Forms.Label adherentIDLabel1;
            System.Windows.Forms.Label disponibleLabel;
            System.Windows.Forms.Label empruntableLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label label1;
            this.prenomTextBox1 = new System.Windows.Forms.TextBox();
            this.nomTextBox1 = new System.Windows.Forms.TextBox();
            this.btnValid = new System.Windows.Forms.Button();
            this.adherentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adherentComboBox = new System.Windows.Forms.ComboBox();
            this.btnPret = new System.Windows.Forms.Button();
            this.disponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.empruntableCheckBox = new System.Windows.Forms.CheckBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.exemplaireBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.exemplaireComboBox = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pretBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pretDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prenomLabel1 = new System.Windows.Forms.Label();
            nomLabel1 = new System.Windows.Forms.Label();
            adherentIDLabel1 = new System.Windows.Forms.Label();
            disponibleLabel = new System.Windows.Forms.Label();
            empruntableLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prenomLabel1
            // 
            prenomLabel1.AutoSize = true;
            prenomLabel1.Location = new System.Drawing.Point(23, 65);
            prenomLabel1.Name = "prenomLabel1";
            prenomLabel1.Size = new System.Drawing.Size(46, 13);
            prenomLabel1.TabIndex = 10;
            prenomLabel1.Text = "Prenom:";
            // 
            // nomLabel1
            // 
            nomLabel1.AutoSize = true;
            nomLabel1.Location = new System.Drawing.Point(23, 39);
            nomLabel1.Name = "nomLabel1";
            nomLabel1.Size = new System.Drawing.Size(32, 13);
            nomLabel1.TabIndex = 8;
            nomLabel1.Text = "Nom:";
            // 
            // adherentIDLabel1
            // 
            adherentIDLabel1.AutoSize = true;
            adherentIDLabel1.Location = new System.Drawing.Point(23, 9);
            adherentIDLabel1.Name = "adherentIDLabel1";
            adherentIDLabel1.Size = new System.Drawing.Size(67, 13);
            adherentIDLabel1.TabIndex = 6;
            adherentIDLabel1.Text = "Adherent ID:";
            // 
            // disponibleLabel
            // 
            disponibleLabel.AutoSize = true;
            disponibleLabel.Location = new System.Drawing.Point(23, 391);
            disponibleLabel.Name = "disponibleLabel";
            disponibleLabel.Size = new System.Drawing.Size(59, 13);
            disponibleLabel.TabIndex = 13;
            disponibleLabel.Text = "Disponible:";
            // 
            // empruntableLabel
            // 
            empruntableLabel.AutoSize = true;
            empruntableLabel.Location = new System.Drawing.Point(23, 421);
            empruntableLabel.Name = "empruntableLabel";
            empruntableLabel.Size = new System.Drawing.Size(69, 13);
            empruntableLabel.TabIndex = 15;
            empruntableLabel.Text = "Empruntable:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(23, 454);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 19;
            iSBNLabel.Text = "ISBN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 362);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 13);
            label1.TabIndex = 21;
            label1.Text = "Id Exemplaire:";
            // 
            // prenomTextBox1
            // 
            this.prenomTextBox1.Enabled = false;
            this.prenomTextBox1.Location = new System.Drawing.Point(96, 62);
            this.prenomTextBox1.Name = "prenomTextBox1";
            this.prenomTextBox1.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox1.TabIndex = 11;
            // 
            // nomTextBox1
            // 
            this.nomTextBox1.Enabled = false;
            this.nomTextBox1.Location = new System.Drawing.Point(96, 36);
            this.nomTextBox1.Name = "nomTextBox1";
            this.nomTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox1.TabIndex = 9;
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(454, 9);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(130, 23);
            this.btnValid.TabIndex = 12;
            this.btnValid.Text = "Charger les prêts";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.BtnValid_Click);
            // 
            // adherentComboBox
            // 
            this.adherentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.adherentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adherentComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.adherentComboBox.DataSource = this.adherentBindingSource1;
            this.adherentComboBox.DisplayMember = "AdherentID";
            this.adherentComboBox.FormattingEnabled = true;
            this.adherentComboBox.IntegralHeight = false;
            this.adherentComboBox.Location = new System.Drawing.Point(96, 9);
            this.adherentComboBox.Name = "adherentComboBox";
            this.adherentComboBox.Size = new System.Drawing.Size(300, 21);
            this.adherentComboBox.TabIndex = 12;
            this.adherentComboBox.ValueMember = "AdherentID";
            // 
            // btnPret
            // 
            this.btnPret.Location = new System.Drawing.Point(454, 39);
            this.btnPret.Name = "btnPret";
            this.btnPret.Size = new System.Drawing.Size(130, 23);
            this.btnPret.TabIndex = 13;
            this.btnPret.Text = "Nouveau prêt";
            this.btnPret.UseVisualStyleBackColor = true;
            this.btnPret.Click += new System.EventHandler(this.BtnPret_Click);
            // 
            // disponibleCheckBox
            // 
            this.disponibleCheckBox.Enabled = false;
            this.disponibleCheckBox.Location = new System.Drawing.Point(102, 386);
            this.disponibleCheckBox.Name = "disponibleCheckBox";
            this.disponibleCheckBox.Size = new System.Drawing.Size(121, 24);
            this.disponibleCheckBox.TabIndex = 14;
            this.disponibleCheckBox.UseVisualStyleBackColor = true;
            this.disponibleCheckBox.CheckedChanged += new System.EventHandler(this.DisponibleCheckBox_CheckedChanged);
            // 
            // empruntableCheckBox
            // 
            this.empruntableCheckBox.Enabled = false;
            this.empruntableCheckBox.Location = new System.Drawing.Point(102, 416);
            this.empruntableCheckBox.Name = "empruntableCheckBox";
            this.empruntableCheckBox.Size = new System.Drawing.Size(121, 24);
            this.empruntableCheckBox.TabIndex = 16;
            this.empruntableCheckBox.UseVisualStyleBackColor = true;
            this.empruntableCheckBox.CheckedChanged += new System.EventHandler(this.EmpruntableCheckBox_CheckedChanged);
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.Enabled = false;
            this.iSBNTextBox.Location = new System.Drawing.Point(102, 451);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(121, 20);
            this.iSBNTextBox.TabIndex = 20;
            // 
            // exemplaireComboBox
            // 
            this.exemplaireComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.exemplaireComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.exemplaireComboBox.DataSource = this.exemplaireBindingSource1;
            this.exemplaireComboBox.DisplayMember = "ISBN";
            this.exemplaireComboBox.FormattingEnabled = true;
            this.exemplaireComboBox.Location = new System.Drawing.Point(102, 359);
            this.exemplaireComboBox.Name = "exemplaireComboBox";
            this.exemplaireComboBox.Size = new System.Drawing.Size(127, 21);
            this.exemplaireComboBox.TabIndex = 20;
            this.exemplaireComboBox.ValueMember = "Disponible";
            this.exemplaireComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExemplaireComboBox_KeyDown);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(454, 69);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(130, 23);
            this.btnRetour.TabIndex = 22;
            this.btnRetour.Text = "Enregistrer retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // pretBindingSource1
            // 
            this.pretBindingSource1.DataSource = typeof(Bibliotheque.BOL.Pret);
            // 
            // pretDataGridView
            // 
            this.pretDataGridView.AutoGenerateColumns = false;
            this.pretDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pretDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.pretDataGridView.DataSource = this.pretBindingSource1;
            this.pretDataGridView.Location = new System.Drawing.Point(26, 114);
            this.pretDataGridView.Name = "pretDataGridView";
            this.pretDataGridView.Size = new System.Drawing.Size(676, 220);
            this.pretDataGridView.TabIndex = 22;
            this.pretDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PretDataGridView_CellClick_1);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AdherentID";
            this.dataGridViewTextBoxColumn7.HeaderText = "AdherentID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Adherent";
            this.dataGridViewTextBoxColumn8.HeaderText = "Adherent";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdExemplaire";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdExemplaire";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Exemplaire";
            this.dataGridViewTextBoxColumn10.HeaderText = "Exemplaire";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DateEmprunt";
            this.dataGridViewTextBoxColumn11.HeaderText = "DateEmprunt";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DateRetour";
            this.dataGridViewTextBoxColumn12.HeaderText = "DateRetour";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // FormPret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 633);
            this.Controls.Add(this.pretDataGridView);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(label1);
            this.Controls.Add(this.exemplaireComboBox);
            this.Controls.Add(disponibleLabel);
            this.Controls.Add(this.disponibleCheckBox);
            this.Controls.Add(empruntableLabel);
            this.Controls.Add(this.empruntableCheckBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(this.btnPret);
            this.Controls.Add(this.adherentComboBox);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(adherentIDLabel1);
            this.Controls.Add(nomLabel1);
            this.Controls.Add(this.nomTextBox1);
            this.Controls.Add(prenomLabel1);
            this.Controls.Add(this.prenomTextBox1);
            this.Name = "FormPret";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox prenomTextBox1;
        private System.Windows.Forms.TextBox nomTextBox1;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.BindingSource adherentBindingSource1;
        private System.Windows.Forms.ComboBox adherentComboBox;
        private System.Windows.Forms.Button btnPret;
        private System.Windows.Forms.CheckBox disponibleCheckBox;
        private System.Windows.Forms.CheckBox empruntableCheckBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.BindingSource exemplaireBindingSource1;
        private System.Windows.Forms.ComboBox exemplaireComboBox;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.BindingSource pretBindingSource1;
        private System.Windows.Forms.DataGridView pretDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

