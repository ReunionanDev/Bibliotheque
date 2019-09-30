namespace GestionPretForm
{
    partial class FormAdherent
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
            System.Windows.Forms.Label adherentIDLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adherentIDTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.adherentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreerAdherent = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnModifyAdherent = new System.Windows.Forms.Button();
            this.btnValidateModify = new System.Windows.Forms.Button();
            adherentIDLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Bibliotheque.BOL.Adherent);
            // 
            // adherentIDLabel
            // 
            adherentIDLabel.AutoSize = true;
            adherentIDLabel.Location = new System.Drawing.Point(42, 48);
            adherentIDLabel.Name = "adherentIDLabel";
            adherentIDLabel.Size = new System.Drawing.Size(67, 13);
            adherentIDLabel.TabIndex = 2;
            adherentIDLabel.Text = "Adherent ID:";
            // 
            // adherentIDTextBox
            // 
            this.adherentIDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.adherentIDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.adherentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "AdherentID", true));
            this.adherentIDTextBox.Location = new System.Drawing.Point(115, 45);
            this.adherentIDTextBox.Name = "adherentIDTextBox";
            this.adherentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.adherentIDTextBox.TabIndex = 3;
            this.adherentIDTextBox.TextChanged += new System.EventHandler(this.AdherentIDTextBox_TextChanged);
            this.adherentIDTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AdherentIDTextBox_Validating);
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(42, 74);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 4;
            nomLabel.Text = "Nom:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Nom", true));
            this.nomTextBox.Enabled = false;
            this.nomTextBox.Location = new System.Drawing.Point(115, 71);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 5;
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(42, 100);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 6;
            prenomLabel.Text = "Prenom:";
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Prenom", true));
            this.prenomTextBox.Enabled = false;
            this.prenomTextBox.Location = new System.Drawing.Point(115, 97);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 7;
            // 
            // adherentDataGridView
            // 
            this.adherentDataGridView.AllowUserToDeleteRows = false;
            this.adherentDataGridView.AutoGenerateColumns = false;
            this.adherentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adherentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.adherentDataGridView.DataSource = this.adherentBindingSource;
            this.adherentDataGridView.Location = new System.Drawing.Point(125, 187);
            this.adherentDataGridView.Name = "adherentDataGridView";
            this.adherentDataGridView.ReadOnly = true;
            this.adherentDataGridView.Size = new System.Drawing.Size(548, 220);
            this.adherentDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AdherentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AdherentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnCreerAdherent
            // 
            this.btnCreerAdherent.Location = new System.Drawing.Point(377, 42);
            this.btnCreerAdherent.Name = "btnCreerAdherent";
            this.btnCreerAdherent.Size = new System.Drawing.Size(148, 23);
            this.btnCreerAdherent.TabIndex = 8;
            this.btnCreerAdherent.Text = "Créer nouveau adherent";
            this.btnCreerAdherent.UseVisualStyleBackColor = true;
            this.btnCreerAdherent.Click += new System.EventHandler(this.BtnCreerAdherent_Click);
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(377, 94);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(148, 23);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider nouvel ahdérent";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnModifyAdherent
            // 
            this.btnModifyAdherent.Location = new System.Drawing.Point(588, 42);
            this.btnModifyAdherent.Name = "btnModifyAdherent";
            this.btnModifyAdherent.Size = new System.Drawing.Size(148, 23);
            this.btnModifyAdherent.TabIndex = 10;
            this.btnModifyAdherent.Text = "Modifier adherent";
            this.btnModifyAdherent.UseVisualStyleBackColor = true;
            this.btnModifyAdherent.Click += new System.EventHandler(this.BtnModifyAdherent_Click);
            // 
            // btnValidateModify
            // 
            this.btnValidateModify.Enabled = false;
            this.btnValidateModify.Location = new System.Drawing.Point(588, 94);
            this.btnValidateModify.Name = "btnValidateModify";
            this.btnValidateModify.Size = new System.Drawing.Size(148, 23);
            this.btnValidateModify.TabIndex = 11;
            this.btnValidateModify.Text = "Valider modifications";
            this.btnValidateModify.UseVisualStyleBackColor = true;
            // 
            // FormAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnValidateModify);
            this.Controls.Add(this.btnModifyAdherent);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnCreerAdherent);
            this.Controls.Add(this.adherentDataGridView);
            this.Controls.Add(adherentIDLabel);
            this.Controls.Add(this.adherentIDTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Name = "FormAdherent";
            this.Text = "FormAdherent";
            this.Load += new System.EventHandler(this.FormAdherent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.TextBox adherentIDTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.DataGridView adherentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnCreerAdherent;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnModifyAdherent;
        private System.Windows.Forms.Button btnValidateModify;
    }
}