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

        private static FormAdherent instance;

        public static FormAdherent GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FormAdherent();
                }
                return instance;
            }
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

        //Begin the process of creating a new member
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

        //Create a new member
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
                nomTextBox.Enabled = false;
                prenomTextBox.Enabled = false;
                btnValider.Enabled = false;
                adherents.Add(adherent);
                adherentBindingSource.DataSource = adherents;
            }
        }

        //Begin the process of modifying a new member
        private void BtnModifyAdherent_Click(object sender, EventArgs e)
        {
            adherent = FindAdherent(adherentIDTextBox.Text);
            if(adherent == null)
            {
                MessageBox.Show(" Choississez un adhérent existant à modifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Veuillez saisir les données à modifier puis cliquez sur Valider", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adherentIDTextBox.Enabled = false;
            nomTextBox.Enabled = true;
            prenomTextBox.Enabled = true;
            btnValidateModify.Enabled = true;
        }

        //Validate and modifying the member
        private void BtnValidateModify_Click(object sender, EventArgs e)
        {
            adherent = FindAdherent(adherentIDTextBox.Text);
            if (string.IsNullOrEmpty(nomTextBox.Text) || string.IsNullOrEmpty(prenomTextBox.Text))
            {
                error.SetError(nomTextBox, "Saisir un Nom");
                error.SetError(prenomTextBox, "Saisir un Prenom");
            }
            adherent.Nom = nomTextBox.Text;
            adherent.Prenom = prenomTextBox.Text;
            AdherentDAO.Instance.Update(adherent);
            adherentBindingSource.ResetBindings(false);
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

        //Search a member when Enter is pressed
        private void AdherentIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(adherentIDTextBox.Text))
                {
                    adherent = FindAdherent(adherentIDTextBox.Text);
                    if(adherent != null)
                    {
                        adherentBindingSource.DataSource = adherent;
                        adherentBindingSource.ResetBindings(false);
                    }
                    else
                    {
                        MessageBox.Show("Adhérent inexistant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
        }

        //Delete and adherent who have no Loan 
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            adherent = FindAdherent(adherentIDTextBox.Text);
            adherent.Prets.SymmetricExceptWith(PretDAO.Instance.GetListePretsEncoursByIdAdherent(adherent.AdherentID));
            if (adherent == null)
            {
                MessageBox.Show("Choississez un adhérent existant à supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (adherent.Prets.Count > 0)
            {
                MessageBox.Show("Cet adhérent à des prêts en cours, suppression impossible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show($"Voulez vous effacer l'ahdérent n°{adherent.AdherentID} ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AdherentDAO.Instance.Delete(adherent.AdherentID);
                adherentBindingSource.DataSource = AdherentDAO.Instance.GetAll();

            }
        }
    }
}
