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
using Bibliotheque.ConsoleWindows;


namespace GestionPretForm
{
    public partial class FormPret : Form
    {
        //Adherent adherent;
        Exemplaire exemplaire;
        HashSet<Exemplaire> listeExemplaire;
        HashSet<Adherent> liste;
        Pret pret;

        public FormPret()
        {
            InitializeComponent();
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void BtnValid_Click(object sender, EventArgs e)
        {
            Adherent adherent = new Adherent();
            adherent = AdherentDAO.Instance.GetByID(adherentComboBox.Text);
            HashSet<Pret> listePret = new HashSet<Pret>();
            try
            { 
                listePret = PretDAO.Instance.GetListePretsEncoursByIdAdherent(adherent.AdherentID);
                pretBindingSource1.DataSource = listePret;
            }
            catch(Exception)
            {
                MessageBox.Show("Veuillez choisir un adherent existant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnPret_Click(object sender, EventArgs e)
        {
            Pret pret = new Pret
            {
                AdherentID = adherentComboBox.Text,
                IdExemplaire = int.Parse(exemplaireComboBox.Text),
                DateEmprunt = DateTime.Today
            };
            Adherent adherent = new Adherent();
            adherent = AdherentDAO.Instance.GetByID(adherentComboBox.Text);
            adherent.Prets.SymmetricExceptWith(PretDAO.Instance.GetListePretsEncoursByIdAdherent(adherent.AdherentID));
            if (adherent.Prets.Count < 5)
            {
                if (MessageBox.Show($"Voulez vous affecter l'exemplaire n°{exemplaireComboBox.Text} à l'adhérent {adherentComboBox.Text}?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        PretDAO.Instance.Create(pret);
                        MessageBox.Show($"Vous avez enregistré un nouveau prêt : Exemplaire n°{exemplaireComboBox.Text} à l'adhérent {adherentComboBox.Text}", "Message", MessageBoxButtons.OK);
                        pretBindingSource1.Add(pret);
                        disponibleCheckBox.Checked = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Veuillez choisir un adherent existant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("L'adherent à trop de prêt en cours", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DisponibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxState();
        }

        /// <summary>
        /// Check if if the checkbox is Checked or not and Enable the "Nouveau Pret" button if the book is Avalaible
        /// </summary>
        private void CheckBoxState()
        {
           
            if (disponibleCheckBox.Checked == true && empruntableCheckBox.Checked == true)
            {
                btnPret.Enabled = true;
            }
            else
            {
                btnPret.Enabled = false;
            }
        }

        private void EmpruntableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxState();
        }

        private void LoadData()
        {
            //Load Datas of Adherent object
            liste = AdherentDAO.Instance.GetAll();
            adherentBindingSource1.DataSource = liste;
            adherentComboBox.DisplayMember = "AdherentID";
            nomTextBox1.DataBindings.Add("Text", adherentBindingSource1, "Nom");
            prenomTextBox1.DataBindings.Add("Text", adherentBindingSource1, "Prenom");

            //Load Datas of Exemplaire object
            listeExemplaire = ExemplaireDAO.Instance.GetAll();
            exemplaireBindingSource1.DataSource = listeExemplaire;
            exemplaireComboBox.DisplayMember = "IdExemplaire";
            iSBNTextBox.DataBindings.Add("Text", exemplaireBindingSource1, "ISBN");
            empruntableCheckBox.DataBindings.Add("Checked", exemplaireBindingSource1, "Empruntable");
            disponibleCheckBox.DataBindings.Add("Checked", exemplaireBindingSource1, "Disponible");
        }

        //Check properties of an exemplaire after pressing Enter
        private void ExemplaireComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(exemplaireComboBox.Text))
                {
                    MessageBox.Show("Veuillez choisir un exemplaire à rechercher", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        exemplaire = ExemplaireDAO.Instance.GetByID(Convert.ToInt32(exemplaireComboBox.Text));
                        exemplaireBindingSource1.DataSource = exemplaire;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Veuillez choisir un exemplaire existant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Update the exemplaire combo box with the one selected in the grid
        private void PretDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                exemplaire = ExemplaireDAO.Instance.GetByID((int)pretDataGridView.SelectedCells[2].Value);
                exemplaireBindingSource1.DataSource = exemplaire;
            }
            catch (Exception)
            {
                //reload the list in the exmplaire combo box
                listeExemplaire = ExemplaireDAO.Instance.GetAll();
                exemplaireBindingSource1.DataSource = listeExemplaire;
                return;
            }
        }

        //Register the return of a book
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = pretDataGridView.CurrentRow;
            if(row == null)
            {
                return;
            }
            pret = row.DataBoundItem as Pret;
            pret.DateRetour = DateTime.Today;
            PretDAO.Instance.Update(pret);
            pretBindingSource1.Remove(pret);
            MessageBox.Show("Retour enregistré avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
