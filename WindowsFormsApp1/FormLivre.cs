using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque.BOL;
using Bibliotheque.DAL;

namespace GestionPretForm
{
    public partial class FormLivre : Form
    {
        HashSet<Livre> livres = new HashSet<Livre>();
        Livre livre;

        public FormLivre()
        {
            InitializeComponent();
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
        }

        private static FormLivre instance;

        public static FormLivre GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FormLivre();
                }
                return instance;
            }
        }

        private void FormLivre_Load(object sender, EventArgs e)
        {
            livres = LivreDAO.Instance.GetAll();
            AutoComplete();
            //livreBindingSource.DataSource = livres;
        }

        private void TitreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                livres = LivreDAO.Instance.GetAll();
                HashSet<Livre> found = new HashSet<Livre>();
                foreach (Livre item in livres)
                {
                    if (!string.IsNullOrEmpty(titreTextBox.Text) && item.Titre.StartsWith(titreTextBox.Text))
                    {
                        found.Add(item);
                    }
                }
                if(found.Count > 0)
                {
                    livreBindingSource.DataSource = found;
                    btnModifyBook.Enabled = true;
                    error.Clear();
                }
                else
                {
                    error.SetError(titreTextBox, "aucun titre trouvé");
                    btnModifyBook.Enabled = false;
                }
            }
        }

        private void AutoComplete()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (Livre item in livres)
            {
                collection.Add(item.Titre);
            }
            titreTextBox.AutoCompleteCustomSource = collection;
        }

        private void BtnModifyBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Voulez vous modifier le livre {titreTextBox.Text} ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                livre = LivreDAO.Instance.GetByISBN(this.iSBNTextBox.Text);
                FormModifyBook form = new FormModifyBook();
                form.libelleComboBox.Enabled = false;
                form.titreTextBox.Text = this.titreTextBox.Text;
                form.idCategorieTextBox.Text = this.idCategorieTextBox.Text;
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    livre.ISBN = this.iSBNTextBox.Text;
                    livre.Titre = form.titreTextBox.Text;
                    livre.IdCategorie = int.Parse(form.idCategorieTextBox.Text);
                    LivreDAO.Instance.Update(livre);
                    livreBindingSource.DataSource = livre;
                }
                
            }
        }

        private void BtnAjouterLivre_Click(object sender, EventArgs e)
        {
            FormModifyBook form = new FormModifyBook();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                livre = new Livre();
                livre.ISBN = form.iSBNTextBox.Text;
                livre.Titre = form.titreTextBox.Text;
                livre.IdCategorie = int.Parse(form.idCategorieTextBox.Text);
                //LivreDAO.Instance.Create(livre);
                livreBindingSource.DataSource = livre;
            }
        }
    }
}
