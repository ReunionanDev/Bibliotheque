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
    public partial class FormModifyBook : Form
    {
        HashSet<Categorie> categories = new HashSet<Categorie>();

        public FormModifyBook()
        {
            InitializeComponent();
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
        }

        private void FormModifyBook_Load(object sender, EventArgs e)
        {
            categories = CategorieDAO.Instance.GetAll();
            categorieBindingSource.DataSource = categories;
            libelleComboBox.DisplayMember = "LibelleCategorie";
            idCategorieTextBox.DataBindings.Add("Text", categorieBindingSource,"Id");
        }
    }
}
