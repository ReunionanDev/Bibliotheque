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

            HashSet<Adherent> liste = new HashSet<Adherent>();
            liste = AdherentDAO.Instance.GetAll();
            adherentBindingSource1.DataSource = liste;
            adherentComboBox.DisplayMember = "AdherentID";
            nomTextBox1.DataBindings.Add("Text", adherentBindingSource1, "Nom");
            prenomTextBox1.DataBindings.Add("Text", adherentBindingSource1, "Prenom");

            HashSet<Exemplaire> listeExemplaire = new HashSet<Exemplaire>();
            listeExemplaire = ExemplaireDAO.Instance.GetAll();
            exemplaireBindingSource1.DataSource = listeExemplaire;
            exemplaireComboBox.DisplayMember = "IdExemplaire";
            iSBNTextBox.DataBindings.Add("Text", exemplaireBindingSource1, "ISBN");
            empruntableCheckBox.DataBindings.Add("Checked", exemplaireBindingSource1, "Empruntable");
        }

        private void BtnValid_Click(object sender, EventArgs e)
        {
            Adherent adherent = new Adherent();
            adherent = AdherentDAO.Instance.GetByID(adherentComboBox.Text);
            HashSet<Pret> listePret = new HashSet<Pret>();
            adherent.Prets.SymmetricExceptWith(PretDAO.Instance.GetListePretsEncoursByIdAdherent(adherent.AdherentID));
            listePret = adherent.Prets;
            pretBindingSource.DataSource = listePret;

        }

        private void BtnPret_Click(object sender, EventArgs e)
        {

        }
    }
}
