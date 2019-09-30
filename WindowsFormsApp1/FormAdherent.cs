using Bibliotheque.BOL;
using Bibliotheque.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPretForm
{
    public partial class FormAdherent : Form
    {
        private HashSet<Adherent> adherents = new HashSet<Adherent>();
        private Adherent adherent;

        public FormAdherent()
        {
            InitializeComponent();
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
        }

        private Adherent FindAdherent(string search)
        {
            foreach (Adherent item in adherents)
            {
                if (item.AdherentID.Contains(search))
                {
                    return item;
                }
            }

            return null;
        }

        private void FormAdherent_Load(object sender, EventArgs e)
        {
            adherents = AdherentDAO.Instance.GetAll();
            adherentBindingSource.DataSource = adherents;

            AutoComplete();
        }

        private void BtnCreerAdherent_Click(object sender, EventArgs e)
        {
            //Clear all textboxes and show message to begin the input of a new Adherent"
            nomTextBox.Clear();
            adherentIDTextBox.Clear();
            prenomTextBox.Clear();
            MessageBox.Show("Veuillez saisir les données du nouvel adhérent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nomTextBox.Enabled = true;
            prenomTextBox.Enabled = true;
            btnValider.Enabled = true;
            btnCreerAdherent.Enabled = false;

            //Add a new Row to register the new Adherent"
            adherentBindingSource.AllowNew = true;
            adherentBindingSource.AddNew();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            //Creating the new Adherent with all inputs
            adherent = new Adherent();
            adherent.AdherentID = adherentIDTextBox.Text;
            adherent.Nom = nomTextBox.Text;
            adherent.Prenom = prenomTextBox.Text;

            //Checking if the Adherent is not already in the list
            foreach (Adherent item in adherents)
            {
                if (adherent.Equals(item))
                {
                    MessageBox.Show("Un adhérent avec cet ID est déja existant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnCreerAdherent.Enabled = true;
                }
            }
            if(adherentIDTextBox.Text != string.Empty)
            {
                AdherentDAO.Instance.Create(adherent);
                MessageBox.Show($"Vous avez enregistré un nouvel adhérent : ID n°{adherentIDTextBox.Text}", "Message", MessageBoxButtons.OK);
                adherentBindingSource.ResetBindings(false);
                btnCreerAdherent.Enabled = true;
            }
        }

        private void BtnModifyAdherent_Click(object sender, EventArgs e)
        {
            
        }
        
        private void AutoComplete()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach(Adherent item in adherents)
            {
                collection.Add(item.AdherentID);
            }
            adherentIDTextBox.AutoCompleteCustomSource = collection;
        }
    }
}
