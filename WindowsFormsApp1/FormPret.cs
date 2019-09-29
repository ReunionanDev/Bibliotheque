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
                adherent.Prets.SymmetricExceptWith(PretDAO.Instance.GetListePretsEncoursByIdAdherent(adherent.AdherentID));
                listePret = adherent.Prets;
                pretBindingSource.DataSource = listePret;
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
            HashSet<Adherent> liste = new HashSet<Adherent>();
            liste = AdherentDAO.Instance.GetAll();
            adherentBindingSource1.DataSource = liste;
            adherentComboBox.DisplayMember = "AdherentID";
            nomTextBox1.DataBindings.Add("Text", adherentBindingSource1, "Nom");
            prenomTextBox1.DataBindings.Add("Text", adherentBindingSource1, "Prenom");

            ///Load Datas of Exemplaire object
            HashSet<Exemplaire> listeExemplaire = new HashSet<Exemplaire>();
            listeExemplaire = ExemplaireDAO.Instance.GetAll();
            exemplaireBindingSource1.DataSource = listeExemplaire;
            exemplaireComboBox.DisplayMember = "IdExemplaire";
            iSBNTextBox.DataBindings.Add("Text", exemplaireBindingSource1, "ISBN");
            empruntableCheckBox.DataBindings.Add("Checked", exemplaireBindingSource1, "Empruntable");
            disponibleCheckBox.DataBindings.Add("Checked", exemplaireBindingSource1, "Disponible");
        }

    }
}
