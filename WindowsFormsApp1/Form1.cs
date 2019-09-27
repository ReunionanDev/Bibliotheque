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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
    
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //this.adherentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HashSet<Adherent> liste = new HashSet<Adherent>();
            liste = AdherentDAO.Instance.GetAll();
            adherentBindingSource1.DataSource = liste;
            adherentComboBox.DisplayMember = "AdherentID";
            nomTextBox1.DataBindings.Add("Text", adherentBindingSource1, "Nom");
            prenomTextBox1.DataBindings.Add("Text", adherentBindingSource1, "Prenom");

            //this.exemplaireComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HashSet<Exemplaire> listeExemplaire = new HashSet<Exemplaire>();
            listeExemplaire = ExemplaireDAO.Instance.GetAll();
            exemplaireBindingSource1.DataSource = listeExemplaire;
            exemplaireComboBox.DisplayMember = "IdExemplaire";
            iSBNTextBox.DataBindings.Add("Text", exemplaireBindingSource1, "ISBN");
            empruntableCheckBox.DataBindings.Add("Checked", exemplaireBindingSource1, "Empruntable");
            disponibleCheckBox.DataBindings.Add("Checked", exemplaireBindingSource1, "Disponible");
            
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
            if(MessageBox.Show($"Voulez vous affecter l'exemplaire n°{exemplaireComboBox.Text} à l'adhérent {adherentComboBox.Text}?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PretDAO.Instance.Create(pret);
            }
        }
        
    }
}
